namespace Data_Structures_Practices
{
    static internal class MyMath
    {

        private enum Statuses
        {
            Success,
            Equals
        }

        public static Tuple<double, string> Min(double a, double b)
        {
            string status = Statuses.Success.ToString();
            if (b > a)
            {
                return new Tuple<double, string>(a, status);
            }
            if (a == b)
            {
                status = Statuses.Equals.ToString();
            }
            return new Tuple<double, string>(b, status);
        }

    }
}
