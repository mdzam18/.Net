namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string word = Console.ReadLine();
            if (word == null)
                return;
            int letters = CountLetters(word);
            int numbers = CountNumbers(word);
            PrintResult(letters, numbers, word);
        }

        private static void PrintResult(int letters, int numbers, string word)
        {
            int others = word.Length - letters - numbers;
            Console.WriteLine("\"{0}\" -> Letters: {1}, Numbers: {2}, Others: {3}", word, letters, numbers, others);
        }

        private static int CountNumbers(string word)
        {
            int numbers = 0;
            char[] chars = word.ToCharArray();
            foreach (char c in chars)
            {
                if (char.IsDigit(c))
                {
                    numbers++;
                }
            }
            return numbers;
        }

        private static int CountLetters(string word)
        {
            int letters = 0;
            char[] chars = word.ToCharArray();
            foreach (char c in chars)
            {
                if (char.IsLetter(c))
                {
                    letters++;
                }
            }
            return letters;
        }

    }
}