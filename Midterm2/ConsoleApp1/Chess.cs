using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Chess
    {

        List<Figure> _Figures;
        Figure _Current;
        Figure[,] _Positions;

        public Chess()
        {
            _Figures = new List<Figure>();
            _Positions = new Figure[8, 8];

            Figure king = new King(1, new Tuple<int, int>(0, 0), "King");
            _Figures.Add(king);
            _Positions[0, 0] = king;

            Figure king2 = new King(2, new Tuple<int, int>(1, 1), "King");
            _Figures.Add(king2);
            _Positions[1, 1] = king2;

            king.Move(new Tuple<int, int>(1, 1));
        }

        private void ShowFigures()
        {
            for (int i = 0; i < _Figures.Count; i++)
            {
                Console.WriteLine("{0} {1}", i + 1, _Figures[i].Name);
            }
        }

        public void Play()
        {
            ShowFigures();
            SelectFigure();
            ChoosePointToMove();
        }

        private void ChoosePointToMove()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (_Positions[x, y] == null)
            {
                _Current.Move(new Tuple<int, int>(x, y));
            }
            CheckIfFigureIsKilled(x, y);
        }

        private void CheckIfFigureIsKilled(int x, int y)
        {
            if (_Positions[x, y] != null)
            {
                if (_Positions[x, y].Color != _Current.Color)
                {
                    _Figures.Remove(_Positions[x, y]);
                    _Positions[x, y] = null;
                }
            }
        }

        private void SelectFigure()
        {
            int number = int.Parse(Console.ReadLine());
            _Current = _Figures[number];
        }

    }
}
