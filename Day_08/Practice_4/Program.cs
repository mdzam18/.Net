namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = 0;
            bool b = int.TryParse(Console.ReadLine(), out number);
            Console.Write("Enter a degree: ");
            int degree = 0;
            bool b2 = int.TryParse(Console.ReadLine(), out degree);
            if (b && b2)
            {
                Console.WriteLine(ComputePowerOfNumber(number, degree));

                Console.WriteLine("Tail recursion");

                Console.WriteLine(ComputePowerOfNumberWithTailRecursion(number, degree, 1));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        private static double ComputePowerOfNumber(int number, int degree)
        {
            if (degree == 0)
            {
                return 1;
            }
            if (degree > 0)
            {
                return number * ComputePowerOfNumber(number, degree - 1);
            }
            else
            {
                return (1.0 / number) * ComputePowerOfNumber(number, degree + 1);
            }
        }

        private static double ComputePowerOfNumberWithTailRecursion(int number, int degree, double current)
        {
            if (degree == 0)
            {
                return current;
            }
            if (degree > 0)
            {
                degree--;
                current *= number;
            }
            else
            {
                degree++;
                current *= 1.0 / number;
            }
            return ComputePowerOfNumberWithTailRecursion(number, degree, current);
        }

    }
}
