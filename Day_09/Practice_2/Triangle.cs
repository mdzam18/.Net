namespace Practice_2
{
    internal class Triangle
    {
        double _Side1;
        double _Side2;
        double _Side3;

        public double Side1
        {
            get
            {
                return _Side1;
            }
            set
            {
                if (value > 0)
                {
                    _Side1 = value;
                }
            }
        }

        public double Side2
        {
            get
            {
                return _Side2;
            }
            set
            {
                if (value > 0)
                {
                    _Side2 = value;
                }
            }
        }

        public double Side3
        {
            get
            {
                return _Side3;
            }
            set
            {
                if (value > 0 && IsTriangle(_Side1, _Side2, value))
                {
                    _Side3 = value;
                }
                else
                {
                    Console.WriteLine("It is not valid triangle");
                }
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

        public double AreaOfTriangle()
        {
            double perimeter = PerimeterOfTriangle();
            double area = 0.25 * Math.Sqrt(perimeter * (perimeter - 2 * _Side1) * (perimeter - 2 * _Side2) * (perimeter - 2 * _Side3));
            return area;
        }

        public double PerimeterOfTriangle()
        {
            return _Side1 + _Side2 + _Side3;
        }

    }
}
