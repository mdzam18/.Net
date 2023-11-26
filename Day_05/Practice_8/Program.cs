namespace Practice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 8;
            int cols = 8;
            int[,] multiArr = new int[rows, cols];
            CreateMultiArry(multiArr, rows, cols);
            multiArr = ConvertToDifferentMatrix(multiArr, rows, cols);
            PrintResult(multiArr, rows, cols);

            Console.WriteLine();
            Console.WriteLine("With jagged array");
            Console.WriteLine();

            int[][] jaggedArray = new int[rows][];
            CreateJaggedArray(jaggedArray, rows, cols);
            jaggedArray = ConvertJaggedArrayToDifferentMatrix(jaggedArray, rows, cols);
            PrintResultForJaggedArray(jaggedArray, rows, cols);
        }

        private static void PrintResultForJaggedArray(int[][] jaggedArray, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[][] ConvertJaggedArrayToDifferentMatrix(int[][] jaggedArray, int rows, int cols)
        {
            int[][] curr = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                curr[rows - i - 1] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    curr[rows - i - 1][j] = jaggedArray[i][j];
                }
            }
            return curr;
        }

        private static void CreateJaggedArray(int[][] jaggedArray, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    if (j <= i)
                    {
                        jaggedArray[i][j] = 0;
                    }
                    else
                    {
                        jaggedArray[i][j] = 1;
                    }
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintResult(int[,] multiArr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(multiArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] ConvertToDifferentMatrix(int[,] multiArr, int rows, int cols)
        {
            int[,] curr = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    curr[rows - i - 1, j] = multiArr[i, j];
                }
            }
            return curr;
        }

        private static void CreateMultiArry(int[,] multiArr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j <= i)
                    {
                        multiArr[i, j] = 0;
                    }
                    else
                    {
                        multiArr[i, j] = 1;
                    }
                    Console.Write(multiArr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}