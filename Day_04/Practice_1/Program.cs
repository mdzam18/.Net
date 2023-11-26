namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 10;
            int sum = 0;
            for(int i = start; i <= end; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from {start} to {end} is {sum}"); 
        }
    }
}