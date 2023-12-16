using System.Text;

namespace Extensions_Practices
{
    public static class CollectionExtension
    {

        public static int[] MergeTwoSequences(this int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                result[i + arr1.Length] = arr2[i];
            }
            return result;
        }

        public static string GenerateStringWithSeparator(this int[] arr, string separator)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int item in arr)
            {
                sb.Append(item);
                sb.Append(separator);
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - separator.Length, separator.Length);
            }
            return sb.ToString();
        }
    }
}
