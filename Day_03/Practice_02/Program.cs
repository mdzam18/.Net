namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = readNumber("first");
            double b = readNumber("second");
            double c = readNumber("third");
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            if (isTriangle(a, b, c))
            {
                Console.WriteLine("This should be a triangle !");
            }
            else
            {
                Console.WriteLine("This can't be a triangle !");
            }
        }

        static bool isTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }

        static double readNumber(String str)
        {
            Console.WriteLine("Enter " + str + " number :");
            double a = 0;
            double.TryParse(Console.ReadLine(), out a);
            if(a < 0)
            {
                a = 0;
            }
            return a;
        }
    }
}
