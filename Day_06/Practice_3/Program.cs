namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = FillArray();
            if (arr == null)
                return;
            int[] minAndMax = FindMinAndMaxElems(arr);
            Console.WriteLine($"The minimum number in the array is {minAndMax[0]}");
            Console.WriteLine($"The maximum number in the array is {minAndMax[1]}");
        }

        private static int[] FindMinAndMaxElems(int[] arr)
        {
            int[] minAndMax = new int[2];
            int min = arr[0];
            int max = arr[0];
            foreach (int elem in arr)
            {
                if (min > elem)
                {
                    min = elem;
                }
                if (max < elem)
                {
                    max = elem;
                }
            }
            minAndMax[0] = min;
            minAndMax[1] = max;
            return minAndMax;
        }

        private static int[] FillArray()
        {
            Console.Write("Enter size of array: ");
            int length = 0;
            bool b = int.TryParse(Console.ReadLine(), out length);
            if (b && length > 0)
            {
                int[] arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"Enter integer for index {i}: ");
                    int curr;
                    b = int.TryParse(Console.ReadLine(), out curr);
                    if (b)
                    {
                        arr[i] = curr;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number");
                        return null;
                    }
                }
                return arr;
            }
            else
            {
                Console.WriteLine("Invalid length");
                return null;
            }
        }

    }
}
