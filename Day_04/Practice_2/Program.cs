namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = 0;
            bool b = int.TryParse(Console.ReadLine(), out number); 
            if(b)
            {
                int sum = 0;
                for(int i = 1; i <= number; i++)
                {
                    sum += i;
                } 
                if(number >= 1)
                {
                    Console.WriteLine($"Sum from 1 to {number} is {sum}");
                }
            } 
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}