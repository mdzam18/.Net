namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = 0;
            bool b = int.TryParse(Console.ReadLine(), out number); 
            if(b && number >= 1)
            {
                for(int i = 1; i <= number; i++)
                {
                    int cubed = (int)Math.Pow(i, 3);
                    Console.WriteLine($"{i} cubed is {cubed}");
                }
            } 
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}