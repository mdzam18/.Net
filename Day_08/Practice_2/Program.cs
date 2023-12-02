namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = 0;
            bool b = int.TryParse(Console.ReadLine(), out n);
            if (b && n > 0)
            {
                Console.WriteLine(FindSum(n));

                Console.WriteLine("Tail recursion");

                Console.WriteLine(FindSumWithTailRecursion(n, 0));
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }

        private static int FindSum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + FindSum(n - 1);
        }

        private static int FindSumWithTailRecursion(int n, int currentSum)
        {
            if (n == 0)
            {
                return currentSum;
            }
            currentSum += n;
            n--;
            return FindSumWithTailRecursion(n, currentSum);
        }

    }
}
