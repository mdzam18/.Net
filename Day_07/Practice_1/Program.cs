using System.Text;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            bool isCharacterTypeVowel = false;
            int count = CountCharacters(str, isCharacterTypeVowel);
            if (isCharacterTypeVowel)
            {
                Console.WriteLine("Vowel count: {0}", count);
            }
            else
            {
                Console.WriteLine("Consonant count: {0}", count);
            }
            PrintResult(str, isCharacterTypeVowel);
        }

        private static void PrintResult(string str, bool isCharacterTypeVowel = true)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] charArray = str.ToCharArray();
            StringBuilder vowelsInString = new StringBuilder();
            StringBuilder consonantsInString = new StringBuilder();
            foreach (char c in charArray)
            {
                if (vowels.Contains(c))
                {
                    vowelsInString.Append(" ");
                    vowelsInString.Append(c);
                }
                else if (char.IsLetter(c))
                {
                    consonantsInString.Append(" ");
                    consonantsInString.Append(c);
                }
            }
            if (isCharacterTypeVowel)
            {
                Console.WriteLine("Vowels:{0}", vowelsInString);
                return;
            }
            Console.WriteLine("Consonants:{0}", consonantsInString);
        }

        private static int CountCharacters(string str, bool isCharacterTypeVowel = true)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] charArray = str.ToCharArray();
            int vowelsCount = 0;
            int consonantsCount = 0;
            foreach (char c in charArray)
            {
                if (vowels.Contains(c))
                {
                    vowelsCount++;
                }
                else if (char.IsLetter(c))
                {
                    consonantsCount++;
                }
            }
            if (isCharacterTypeVowel)
            {
                return vowelsCount;
            }
            return consonantsCount;
        }

    }
}
