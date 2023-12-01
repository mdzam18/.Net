namespace Practice_1
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
                PrintNumbersFromOneToInput(n);

                Console.WriteLine("\nTail Recursion");

                PrintNumbersFromOneToInputWithTailRecursion(n, 1);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }

        private static void PrintNumbersFromOneToInput(int n)
        {
            if (n == 0)
            {
                return;
            }
            PrintNumbersFromOneToInput(n - 1);
            Console.Write("{0} ", n);
        }

        private static void PrintNumbersFromOneToInputWithTailRecursion(int n, int curr)
        {
            if (curr > n)
            {
                return;
            }
            Console.Write("{0} ", curr);
            curr++;
            PrintNumbersFromOneToInputWithTailRecursion(n, curr);
        }

    }
}
