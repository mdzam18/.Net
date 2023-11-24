namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elems = { 1, 2, 3, 4, 5, 6, 7 };
            int index = 2;
            bool b;
            int result = GetElementByIndex(elems, index, out b);
            if (b)
            {
                Console.WriteLine($"Number at index {index} in the array is {result}");
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        private static int GetElementByIndex(int[] elems, int index, out bool b)
        {
            if (index >= 0 && index < elems.Length)
            {
                b = true;
                return elems[index];
            }
            else
            {
                b = false;
                return -1;
            }
        }

    }
}
