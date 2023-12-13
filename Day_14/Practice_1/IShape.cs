namespace Practice_1
{
    internal interface IShape
    {

        public abstract double Perimeter();

        public abstract double Area();

        private static double GetLength(Point a, Point b)
        {
            double length = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
            return length;
        }

        public static double[] CalculateSides(params Point[] points)
        {
            double[] sides = new double[points.Length + 2];
            int currIndex = 0;
            double largest = 0;
            double secondLargest = 0;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    sides[currIndex] = GetLength(points[i], points[j]);
                    if (largest <= sides[currIndex])
                    {
                        secondLargest = largest;
                        largest = sides[currIndex];
                    }
                    currIndex++;
                }
            }
            if (currIndex > points.Length)
            {
                double[] sides2 = new double[points.Length];
                int index = 0;
                foreach (double side in sides)
                {
                    if (side != largest && side != secondLargest)
                    {
                        sides2[index] = side;
                        index++;
                    }
                }
                return sides2;
            }
            return sides;
        }

    }
}
