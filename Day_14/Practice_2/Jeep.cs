﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class Jeep : IVehicle
    {
        public void ShowName()
        {
            Console.WriteLine("Jeep");
        }

        public void Drive()
        {
            Console.WriteLine("Jeep is driving");
        }
    }
}
