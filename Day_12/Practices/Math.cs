namespace Practices
{
    internal static class Math
    {

        private enum Statuses
        {
            PowMustBeAPositiveOrZero,
            Success,
            Equals
        }

        public static double Pow(double b, double power, out string status)
        {
            if (power >= 0)
            {
                double result = 1;
                for (int i = 0; i < power; i++)
                {
                    result *= b;
                }
                status = Statuses.Success.ToString();
                return result;
            }
            status = Statuses.PowMustBeAPositiveOrZero.ToString();
            return -1;
        }

        public static double Min(double a, double b, out string status)
        {
            status = Statuses.Success.ToString();
            if (b > a)
            {
                return a;
            }
            if (a == b)
            {
                status = Statuses.Equals.ToString();
            }
            return b;
        }

        public static double Max(double a, double b, out string status)
        {
            status = Statuses.Success.ToString();
            if (b > a)
            {
                return b;
            }
            if (a == b)
            {
                status = Statuses.Equals.ToString();
            }
            return a;
        }

    }
}
