namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sting: ");
            string sentence = Console.ReadLine();
            if (sentence == null)
                return;
            int count = CountNumberOfWords(sentence);
            PrintNumberOfWords(count);
        }

        private static void PrintNumberOfWords(int count)
        {
            Console.WriteLine(count);
        }

        private static int CountNumberOfWords(string sentence)
        {
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

    }
}
