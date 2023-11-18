namespace Practice6
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
                Console.Write($"divisors of {number} are: ");
                for(int i = 1; i <= number; i++)
                {
                    if(number % i == 0)
                    {
                        Console.Write($"{i}");
                        if(i != number)
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}