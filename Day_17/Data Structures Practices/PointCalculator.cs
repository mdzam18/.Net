namespace Data_Structures_Practices
{
    static internal class PointCalculator
    {

        public static double GetDistance(Tuple<int, int> p1, Tuple<int, int> p2)
        {
            return Math.Sqrt(Math.Pow(p2.Item1 - p1.Item1, 2) + Math.Pow(p2.Item2 - p1.Item2, 2));
        }

    }
}
