using System.Text;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            if (word == null)
            {
                return;
            }
            ReverseString(word);
        }

        private static void ReverseString(string word)
        {
            StringBuilder reversed = new StringBuilder();
            char[] charArray = word.ToCharArray();
            int length = charArray.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                reversed.Append(charArray[i]);
            }
            Console.WriteLine(reversed);
        }

    }
}
