using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class King : Figure
    {

        List<Tuple<int, int>> _PossibleMoves;


        public King(int color, Tuple<int, int> point, String name) : base(color, point, name)
        {
            _PossibleMoves = new List<Tuple<int, int>>();
            FillPossibleMoves();
        }

        public override void FillPossibleMoves()
        {
            Tuple<int, int> poin1 = new Tuple<int, int>(Point.Item1, Point.Item2 + 1);
            Tuple<int, int> poin2 = new Tuple<int, int>(Point.Item1 + 1, Point.Item2);
            Tuple<int, int> poin3 = new Tuple<int, int>(Point.Item1 + 1, Point.Item2 + 1);
            Tuple<int, int> poin4 = new Tuple<int, int>(Point.Item1 - 1, Point.Item2 - 1);
            _PossibleMoves.Add(poin1);
            _PossibleMoves.Add(poin2);
            _PossibleMoves.Add(poin3);
            _PossibleMoves.Add(poin4);
        }

        public override void Move(Tuple<int, int> point2)
        {
            if (_PossibleMoves.Contains(point2))
            {
                Point = point2;
            }
            else
            {
                Console.WriteLine("Invalid position");
            }
        }

    }
}
