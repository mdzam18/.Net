namespace Practice_3
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
                ComputeSum(arr);
            }
            else
            {
                Console.WriteLine("Invalid length");
            }
        }

        private static void ComputeSum(int[] arr)
        {
            int sum = 0;
            foreach (int elem in arr)
            {
                sum += elem;
            }
            Console.WriteLine($"Sum of array elements is {sum}");
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