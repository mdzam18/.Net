namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = FillArray();
            if (arr == null)
                return;
            int number = 5;
            int factorial = FindFactorialIfArrayContainsNumber(arr, number);
            if (factorial == -1)
            {
                if (number < 0)
                {
                    Console.WriteLine("Factorial of negative number is not defined");
                }
                else
                {
                    Console.WriteLine($"Number {number} was not found in the given array");
                }
            }
            else
            {
                Console.WriteLine($"Factorial of {number} is {factorial}");
            }
        }

        private static int FindFactorialIfArrayContainsNumber(int[] arr, int number)
        {
            if (number < 0)
                return -1;
            foreach (int elem in arr)
            {
                if (number == elem)
                {
                    return ComputeFactorial(number);
                }
            }
            return -1;
        }

        private static int ComputeFactorial(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
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
