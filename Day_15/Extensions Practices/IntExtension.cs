namespace Extensions_Practices
{
    public static class IntExtension
    {

        public static bool IsEven(this int value)
        {
            if (value % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static int GetAbsoluteValue(this int value)
        {
            if (value < 0)
            {
                return -1 * value;
            }
            return value;
        }

        public static int RoundToTheNearestMultiple(this int value, int multiple)
        {
            int n = value / multiple;
            int lower = n * multiple;
            int diff1 = value - lower;
            int upper = (n + 1) * multiple;
            int diff2 = upper - value;
            if (Math.Abs(diff1) > Math.Abs(diff2))
            {
                return upper;
            }
            return lower;
        }

    }
}