namespace Practice_2
{
    internal class TestTriangle
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.Write("Enter side 1: ");
            double side1 = 0;
            bool b1 = double.TryParse(Console.ReadLine(), out side1);
            Console.Write("Enter side 2: ");
            double side2 = 0;
            bool b2 = double.TryParse(Console.ReadLine(), out side2);
            Console.Write("Enter side 3: ");
            double side3 = 0;
            bool b3 = double.TryParse(Console.ReadLine(), out side3);
            if (b1 && b2 && b3)
            {
                triangle.Side1 = side1;
                triangle.Side2 = side2;
                triangle.Side3 = side3;
                if (triangle.Side3 > 0)
                {
                    Console.WriteLine("Perimeter of the triangle is: {0}", triangle.PerimeterOfTriangle());
                    Console.WriteLine("Area of the triangle is: {0}", triangle.AreaOfTriangle());
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
