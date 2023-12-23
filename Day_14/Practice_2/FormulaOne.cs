using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class FormulaOne : IVehicle
    {
        public void ShowName()
        {
            Console.WriteLine("Formula 1");
        }

        public void Drive()
        {
            Console.WriteLine("Formula 1 is driving");
        }
    }
}
