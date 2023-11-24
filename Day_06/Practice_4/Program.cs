namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = FillArray();
            if (arr == null)
                return;
            double average = ArithmeticAverageOfArray(arr);
            Console.WriteLine($"Arithmetic average of array is {average}");
        }

        private static double ArithmeticAverageOfArray(int[] arr)
        {
            double sum = 0;
            foreach (int elem in arr)
            {
                sum += elem;
            }
            return sum / arr.Length;
        }

        private static int[] FillArray()
        {
            Console.Write("Enter size of array: ");
            int length = 0;
            bool b = int.TryParse(Console.ReadLine(), out length);
            if (b && length > 0)
            {
                int[] arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"Enter integer for index {i}: ");
                    int curr;
                    b = int.TryParse(Console.ReadLine(), out curr);
                    if (b)
                    {
                        arr[i] = curr;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number");
                        return null;
                    }
                }
                return arr;
            }
            else
            {
                Console.WriteLine("Invalid length");
                return null;
            }
        }

    }
}
