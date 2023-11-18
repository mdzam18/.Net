namespace Practice4
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
                int sum = 0;
                for(int i = 1; i <= number; i++)
                {
                    if(i % 2 != 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine($"Sum of odd numbers from 1 to {number} is {sum}");
            } 
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}