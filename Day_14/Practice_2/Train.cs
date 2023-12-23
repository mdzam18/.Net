using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class Train : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Train is driving");
        }

        public void ShowName()
        {
            Console.WriteLine("Train");
        }
    }
}
