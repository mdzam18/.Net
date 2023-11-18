namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool b = int.TryParse(Console.ReadLine(), out number); 
            if(b && number >= 1)
            {
                int sum = 0;
                for(int i = 1; i <= number; i++)
                {
                    sum += i;
                } 
                Console.WriteLine($"Sum from 1 to {number} is {sum}"); 
            } 
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}