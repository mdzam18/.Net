namespace Practice8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = 0;
            bool b = int.TryParse(Console.ReadLine(), out number);
            int curr = number;
            if(b && number > 0)
            {
                string result = "";
                while(curr != 0)
                {
                    if(curr % 2 == 0)
                    {
                        result = "0" + result;
                    }
                    else
                    {
                        result = "1" + result;
                    }
                    curr /= 2;
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