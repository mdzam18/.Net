using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practice_2.VehicleCategories;

namespace Practice_2
{
    internal class MilitaryCategory : ICategories
    {

        public enum MilitaryCategories
        {
            Tank,
            BTR
        }


        public void ShowVehiclesInCategory()
        {
            Console.WriteLine(MilitaryCategories.Tank);
            Console.WriteLine(MilitaryCategories.BTR);
            string choise = Console.ReadLine();
            ChooseVehicle(choise.ToLower());
        }

        public void ChooseVehicle(string name)
        {
            if (name == MilitaryCategories.Tank.ToString().ToLower())
            {
                Tank tank = new Tank();
                tank.ShowName();
                tank.Drive();
            }
            else if (name == MilitaryCategories.BTR.ToString().ToLower())
            {
                BTR btr = new BTR();
                btr.ShowName();
                btr.Drive();
            }
        }

    }
}
