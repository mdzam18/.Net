namespace Practice_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = FillArray();
            if (arr == null)
                return;
            char c = 'a';
            int frequency = FindCharacterFrequency(arr, c);
            PrintResult(frequency, c);
        }

        private static void PrintResult(int frequency, char c)
        {
            Console.WriteLine($"'{c}' shegvxvda {frequency}-jer");
        }

        private static int FindCharacterFrequency(char[] arr, char c)
        {
            int result = 0;
            foreach (char c2 in arr)
            {
                if (c2 == c)
                {
                    result++;
                }
            }
            return result;
        }

        private static char[] FillArray()
        {
            Console.Write("Enter size of array: ");
            int length = 0;
            bool b = int.TryParse(Console.ReadLine(), out length);
            if (b && length > 0)
            {
                char[] arr = new char[length];
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"Enter character for index {i}: ");
                    char curr;
                    b = char.TryParse(Console.ReadLine(), out curr);
                    if (b)
                    {
                        arr[i] = curr;
                    }
                    else
                    {
                        Console.WriteLine("Invalid character");
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
