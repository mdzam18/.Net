namespace Practice8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = 0;
            bool b = int.TryParse(Console.ReadLine(), out number);
            if(b && number > 0)
            {
                String result = "";
                while(number != 0)
                {
                    if(number % 2 == 0)
                    {
                        result = "0" + result;
                    }
                    else
                    {
                        result = "1" + result;
                    }
                    number /= 2;
                }
                Console.WriteLine($"decimal {number} in binary is {result}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}