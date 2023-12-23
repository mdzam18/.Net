using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Figure
    {
        int _Color;
        Tuple<int, int> _Point;
        string _Name;
        List<Tuple<int, int>> _PossibleMoves;

        public Figure(int color, Tuple<int, int> point, string name)
        {
            _Color = color;
            _Point = point;
            _Name = name;
        }

        public abstract void FillPossibleMoves();

        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public int Color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value;
            }
        }

        public Tuple<int, int> Point
        {
            get
            {
                return _Point;
            }
            set
            {
                _Point = value;
            }
        }

        public abstract void Move(Tuple<int, int> point2);

    }
}
