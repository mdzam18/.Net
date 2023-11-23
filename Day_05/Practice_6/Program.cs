namespace Practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size: ");
            int rowSize = 0;
            bool b = int.TryParse(Console.ReadLine(), out rowSize);
            Console.Write("Enter array column size: ");
            int columnSize = 0;
            bool b2 = int.TryParse(Console.ReadLine(), out columnSize);
            if (b && b2 && rowSize > 0 && columnSize > 0)
            {
                int[,] multiArr = new int[rowSize, columnSize];
                if (!FillMatrix(multiArr, rowSize, columnSize))
                    return;
                PrintMatrix(multiArr, rowSize, columnSize);
            }
            else
            {
                Console.WriteLine("Invalid size");
            }
        }

        private static void PrintMatrix(int[,] multiArr, int rows, int columns)
        {
            Console.WriteLine("Here is matrix view of multidemensional array");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{multiArr[i, j]}, ");
                }
                Console.WriteLine();
            }
        }

        private static bool FillMatrix(int[,] multiArr, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    int curr;
                    bool b = int.TryParse(Console.ReadLine(), out curr);
                    if (b)
                    {
                        multiArr[i, j] = curr;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number");
                        return false;
                    }
                }
            }
            return true;
        }

    }
}