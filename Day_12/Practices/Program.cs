namespace Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find power");
            Console.Write("Enter base: ");
            double baseNumber = 0;
            bool b1 = double.TryParse(Console.ReadLine(), out baseNumber);
            Console.Write("Enter power: ");
            double power = 0;
            bool b2 = double.TryParse(Console.ReadLine(), out power);
            if (b1 && b2)
            {
                string status;
                double result = Math.Pow(baseNumber, power, out status);
                Console.WriteLine(status);
                if (status == "Success")
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine();

            Console.WriteLine("Find min");
            Console.Write("Enter first number: ");
            double first;
            b1 = double.TryParse(Console.ReadLine(), out first);
            Console.Write("Enter second number: ");
            double second;
            b2 = double.TryParse(Console.ReadLine(), out second);
            if (b1 && b2)
            {
                string status;
                double result = Math.Min(first, second, out status);
                Console.WriteLine(status);
                Console.WriteLine("Min: {0}", result);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine();


            Console.WriteLine("Find max");
            Console.Write("Enter first number: ");
            b1 = double.TryParse(Console.ReadLine(), out first);
            Console.Write("Enter second number: ");
            b2 = double.TryParse(Console.ReadLine(), out second);
            if (b1 && b2)
            {
                string status;
                double result = Math.Max(first, second, out status);
                Console.WriteLine(status);
                Console.WriteLine("Max: {0}", result);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine();

        }
    }
}
