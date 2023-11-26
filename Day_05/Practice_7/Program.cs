namespace Practice_7
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
                int[,] multiArr1 = new int[rowSize, columnSize];
                if (!FillMatrix(multiArr1, rowSize, columnSize, "first"))
                    return;
                Console.WriteLine();
                int[,] multiArr2 = new int[rowSize, columnSize];
                if (!FillMatrix(multiArr2, rowSize, columnSize, "second"))
                    return;
                FindSum(multiArr1, multiArr2, rowSize, columnSize);
            }
            else
            {
                Console.WriteLine("Invalid size");
            }
        }

        private static void FindSum(int[,] multiArr1, int[,] multiArr2, int rows, int columns)
        {
            Console.WriteLine("Here is sum of two matrices");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string result = "";
                    if (j == (columns - 1))
                    {
                        result = "" + (multiArr1[i, j] + multiArr2[i, j]) + " ";
                    }
                    else
                    {
                        result = "" + (multiArr1[i, j] + multiArr2[i, j]) + ", ";
                    }
                    Console.Write(result);
                }
                Console.WriteLine();
            }
        }

        private static bool FillMatrix(int[,] multiArr, int rows, int columns, string str)
        {
            Console.WriteLine($"Fill {str} matrix");
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