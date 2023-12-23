namespace Practice_1
{
    internal class Point
    {

        int _X;
        int _Y;

        public Point(int x, int y)
        {
            _X = x;
            _Y = y;
        }

        public int X
        {
            get
            {
                return _X;
            }
        }

        public int Y
        {
            get
            {
                return _Y;
            }
        }

    }
}
