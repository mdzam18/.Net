namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            Console.WriteLine("with third variable");
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("without third variable");
            a = 5;
            b = 7;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}


