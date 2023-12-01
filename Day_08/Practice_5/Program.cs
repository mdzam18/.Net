namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            if (word == null)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            bool isPalindrome = IsPalindrome(word);
            Console.WriteLine("Is palindrome? {0}", isPalindrome);

            Console.WriteLine("Tail Recursion");

            isPalindrome = IsPalindromeWithTailRecursion(word);
            Console.WriteLine("Is palindrome? {0}", isPalindrome);
        }

        private static bool IsPalindrome(string word)
        {
            if (word.Length <= 1)
            {
                return true;
            }
            if (word.Substring(0, 1) == word.Substring(word.Length - 1) && IsPalindrome(word.Substring(1, word.Length - 2)))
            {
                return true;
            }
            return false;
        }

        private static bool IsPalindromeWithTailRecursion(string word)
        {
            if (word.Length <= 1)
            {
                return true;
            }
            string first = word.Substring(0, 1);
            string last = word.Substring(word.Length - 1);
            word = word.Substring(1, word.Length - 2);
            if (first != last)
            {
                return false;
            }
            return IsPalindromeWithTailRecursion(word);
        }

    }
}