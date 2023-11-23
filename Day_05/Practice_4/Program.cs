namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int length = 0;
            bool b = int.TryParse(Console.ReadLine(), out length);
            if (b && length > 0)
            {
                int[] arr = new int[length];
                if (!FillArray(arr, length))
                    return;
                MultiplyArrayElements(arr);
            }
            else
            {
                Console.WriteLine("Invalid length");
            }
        }

        private static void MultiplyArrayElements(int[] arr)
        {
            int result = 1;
            foreach (int elem in arr)
            {
                result *= elem;
            }
            Console.WriteLine($"Product of array elements is {result}");
        }

        private static bool FillArray(int[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                int curr;
                bool b = int.TryParse(Console.ReadLine(), out curr);
                if (b)
                {
                    arr[i] = curr;
                }
                else
                {
                    Console.WriteLine("Invalid number");
                    return false;
                }
            }
            return true;
        }

    }
}