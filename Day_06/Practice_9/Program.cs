namespace Practice_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = ComputeMultiplication(1, 2, 5, 3);
            Console.WriteLine($"The product of array elements is: {result}");
        }

        private static int ComputeMultiplication(params int[] integers)
        {
            if (integers.Length == 0) return 0;
            int result = 1;
            foreach (int i in integers)
            {
                result *= i;
            }
            return result;
        }

    }
}
