namespace Practice_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = FillMatrix();
            if (matrix1 == null)
                return;
            int[,] matrix2 = FillMatrix(matrix1.GetLength(0), matrix1.GetLength(1));
            if (matrix2 == null)
                return;
            int[,] sumMatrix = ComputeSum(matrix1, matrix2);
            PrintSum(sumMatrix);
        }

        private static void PrintSum(int[,] sumMatrix)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Here is sum of matrices");
            int rows = sumMatrix.GetLength(0);
            int columns = sumMatrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string result = "";
                    if (j == (columns - 1))
                    {
                        result = result + sumMatrix[i, j] + " ";
                    }
                    else
                    {
                        result = result + sumMatrix[i, j] + ", ";
                    }
                    Console.Write(result);
                }
                Console.WriteLine();
            }
        }

        private static int[,] ComputeSum(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            int[,] sumMatrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return sumMatrix;
        }

        private static int[,] FillMatrix(int rows = 0, int columns = 0)
        {
            if (rows == 0)
            {
                Console.Write("Enter count of rows: ");
                bool b = int.TryParse(Console.ReadLine(), out rows);
                Console.Write("Enter count of columns: ");
                bool b2 = int.TryParse(Console.ReadLine(), out columns);
                if (!b || !b2 || rows <= 0 || columns <= 0)
                {
                    Console.WriteLine("Invalid input");
                    return null;
                }
            }
            Console.WriteLine("===================================");
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter integer for index {i},{j}: ");
                    int curr;
                    bool b = int.TryParse(Console.ReadLine(), out curr);
                    if (b)
                    {
                        matrix[i, j] = curr;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number");
                        return null;
                    }
                }
            }
            return matrix;
        }
    }

}
