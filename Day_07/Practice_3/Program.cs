namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            if (word == null)
                return;
            InsertSpacesBetweenCharacters(word);
        }

        private static void InsertSpacesBetweenCharacters(string word)
        {
            char[] charArray = word.ToCharArray();
            string result = string.Join(" ", charArray);
            Console.WriteLine(result);
        }

    }
}
