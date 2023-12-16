namespace Extensions_Practices
{
    public static class ArrayExtension
    {

        public static int[] RemoveDuplicates(this int[] arr)
        {
            int duplicatesNumber;
            int[] duplicatesIndexes = FindDuplicatesIndexes(arr, out duplicatesNumber);
            int[] result = new int[arr.Length - duplicatesNumber];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (duplicatesIndexes[i] != 1)
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        private static int[] FindDuplicatesIndexes(int[] arr, out int duplicatesNumber)
        {
            int[] duplicatesIndexes = new int[arr.Length];
            duplicatesNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        if (duplicatesIndexes[i] != 1)
                        {
                            duplicatesNumber++;
                        }
                        duplicatesIndexes[i] = 1;
                        break;
                    }
                }
            }
            return duplicatesIndexes;
        }

        public static bool ContainsElement(this int[] arr, int element)
        {
            foreach (int item in arr)
            {
                if (item == element)
                    return true;
            }
            return false;
        }

        public static int GetMaxElement(this int[] arr)
        {
            int max = int.MinValue;
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

    }
}
