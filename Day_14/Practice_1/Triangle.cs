namespace Practice_1
{
    class Triangle : Shape
    {
        double _Side1;
        double _Side2;
        double _Side3;

        public Triangle(Point a, Point b, Point c, ref bool isTriangle)
        {
            double[] sides = CalculateSides(a, b, c);
            _Side1 = sides[0];
            _Side2 = sides[1];
            _Side3 = sides[2];
            if (!IsTriangle(_Side1, _Side2, _Side3))
            {
                isTriangle = false;
                Console.WriteLine("It is not triangle");
            }
        }

        private bool IsTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }

        public override double Area()
        {
            double perimeter = Perimeter();
            double area = 0.25 * Math.Sqrt(perimeter * (perimeter - 2 * _Side1) * (perimeter - 2 * _Side2) * (perimeter - 2 * _Side3));
            return area;
        }

        public override double Perimeter()
        {
            return _Side1 + _Side2 + _Side3;
        }

    }
}
