﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class Rally : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Rally is driving");
        }

        public void ShowName()
        {
            Console.WriteLine("Rally");
        }
    }
}
