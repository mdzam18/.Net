namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elems = { 126, 2, 120000, 13, 1, -25 };
            int index = 2;
            bool b;
            int sum = ComputeSumOfDigitsInArrayByIndex(elems, index, out b);
            if (b)
            {
                Console.WriteLine($"The sum of the digits of a number at index {index} is {sum}");
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        private static int ComputeSumOfDigitsInArrayByIndex(int[] elems, int index, out bool b)
        {
            if (index >= 0 && index < elems.Length)
            {
                b = true;
                int number = elems[index];
                int sum = 0;
                while (number != 0)
                {
                    int remainder = number % 10;
                    sum += remainder;
                    number /= 10;
                }
                return sum;
            }
            else
            {
                b = false;
                return -1;
            }
        }

    }
}
