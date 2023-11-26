namespace Practice_5
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
                PrintUniqueNumbers(arr, length);
            }
            else
            {
                Console.WriteLine("Invalid length");
            }
        }

        private static void PrintUniqueNumbers(int[] arr, int length)
        {
            Console.WriteLine("Unique elements of array are");
            for (int i = 0; i < length; i++)
            {
                int curr = arr[i];
                bool isUnique = true;
                for (int j = 0; j < length; j++)
                {
                    if (i != j && curr == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(curr);
                }
            }
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