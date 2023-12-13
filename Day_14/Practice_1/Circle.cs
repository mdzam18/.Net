namespace Practice_1
{
    internal class Circle : Shape
    {
        double _Radius;

        public Circle(Point a, Point b, ref bool isCircle)
        {
            _Radius = CalculateSides(a, b)[0];
            if (_Radius == 0)
            {
                isCircle = false;
                Console.WriteLine("It is not circle");
            }
        }

        public override double Area()
        {
            return Math.PI * _Radius * _Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * _Radius;
        }
    }
}
