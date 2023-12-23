namespace Practice_1
{
    internal class Square : Shape
    {
        double _Side1;
        double _Side2;
        double _Side3;
        double _Side4;

        public Square(Point a, Point b, Point c, Point d, ref bool isSquare)
        {
            double[] sides = CalculateSides(a, b, c, d);
            _Side1 = sides[0];
            _Side2 = sides[1];
            _Side3 = sides[2];
            _Side4 = sides[3];
            if (!IsSquare(_Side1, _Side2, _Side3, _Side4))
            {
                Console.WriteLine("It is not square");
                isSquare = false;
            }
        }

        private bool IsSquare(double a, double b, double c, double d)
        {
            if (a == b && c == d || a == c && b == d || a == d && b == c)
            {
                return true;
            }
            return false;
        }

        public override double Area()
        {
            if (_Side1 == _Side2)
            {
                return _Side1 * _Side3;
            }
            return _Side1 * _Side2;
        }

        public override double Perimeter()
        {
            return _Side1 + _Side2 + _Side3 * _Side4;
        }
    }
}
