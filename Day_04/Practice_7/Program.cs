namespace Practice7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = 0;
            bool b = int.TryParse(Console.ReadLine(), out number);
            if(b && number >= 0)
            {
                int first = 0;
                int second = 1;
                int amount = 0;
                while (true)
                {
                    if (amount == number)
                    {
                        Console.Write(first);
                        break;
                    }
                    Console.Write(first + ", ");
                    amount++;
                    int curr = second;
                    second += first;
                    first = curr;
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}