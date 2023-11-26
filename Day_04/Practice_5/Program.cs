namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of rows of Floyd's triangle to be printed: ");
            int rows = 0;
            bool b = int.TryParse(Console.ReadLine(), out rows);
            if(b && rows > 0)
            {
                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < i + 1; j++)
                    {
                        if((i + j) % 2 == 0)
                        {
                            Console.Write("1 ");
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    } 
                    Console.WriteLine();
                }   
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}