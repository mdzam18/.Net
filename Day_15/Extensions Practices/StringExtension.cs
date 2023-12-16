using System.Text;

namespace Extensions_Practices
{
    public static class StringExtension
    {

        public static string Reverse(this string s)
        {
            StringBuilder sb = new StringBuilder();
            var chars = s.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                sb.Append(chars[i]);
            }
            return sb.ToString();
        }

        public static int GetCharacterOccurence(this string s, char c)
        {
            int result = 0;
            var chars = s.ToCharArray();
            foreach (var character in chars)
            {
                if (character == c)
                {
                    result++;
                }
            }
            return result;
        }

        public static bool StartsOrEndsWithSubstring(this string s, string subString)
        {
            if (s.Length < subString.Length)
            {
                return false;
            }
            string start = s.Substring(0, subString.Length);
            string end = s.Substring(s.Length - subString.Length);
            if (start == subString || end == subString)
            {
                return true;
            }
            return false;
        }

    }
}
