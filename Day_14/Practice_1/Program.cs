namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape?[] shapes = new Shape[3];

            Console.WriteLine("Triangle");
            Triangle? triangle = CreateTriangle();
            shapes[0] = triangle;

            Console.WriteLine("\nSquare");
            Square? square = CreateSquare();
            shapes[1] = square;

            Console.WriteLine("\nCircle");
            Circle? circle = CreateCircle();
            shapes[2] = circle;

            foreach (Shape? shape in shapes)
            {
                if (shape != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Perimeter is: {0}", shape.Perimeter());
                    Console.WriteLine("Area is: {0}", shape.Area());
                }
            }
        }

        private static Circle? CreateCircle()
        {
            Point a = EnterPoint();
            Point b = EnterPoint();
            bool isCircle = true;
            Circle circle = new Circle(a, b, ref isCircle);
            if (isCircle)
            {
                return circle;
            }
            return null;
        }

        private static Point EnterPoint()
        {
            Console.Write("Enter x for point: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y for point: ");
            int y = int.Parse(Console.ReadLine());
            return new Point(x, y);
        }

        private static Square? CreateSquare()
        {
            Point a = EnterPoint();
            Point b = EnterPoint();
            Point c = EnterPoint();
            Point d = EnterPoint();

            bool isSquare = true;
            Square square = new Square(a, b, c, d, ref isSquare);
            if (isSquare)
            {
                return square;
            }
            return null;
        }

        private static Triangle? CreateTriangle()
        {
            Point a = EnterPoint();
            Point b = EnterPoint();
            Point c = EnterPoint();

            bool isTriangle = true;
            Triangle triangle = new Triangle(a, b, c, ref isTriangle);
            if (isTriangle)
            {
                return triangle;
            }
            return null;
        }

    }
}
