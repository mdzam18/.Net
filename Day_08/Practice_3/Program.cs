namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = 0;
            bool b = int.TryParse(Console.ReadLine(), out n);
            if (b)
            {
                Console.WriteLine(FindNumberOfDigits(n));

                Console.WriteLine("Tail recursion");

                Console.WriteLine(FindNumberOfDigitsWithTailRecursion(n, 1));
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }

        private static int FindNumberOfDigits(int n)
        {
            if (Math.Abs(n) <= 9)
            {
                return 1;
            }
            return 1 + FindNumberOfDigits(n / 10);
        }

        private static int FindNumberOfDigitsWithTailRecursion(int n, int currentNumber)
        {
            if (Math.Abs(n) <= 9)
            {
                return currentNumber;
            }
            n = n / 10;
            currentNumber++;
            return FindNumberOfDigitsWithTailRecursion(n, currentNumber);
        }

    }
}