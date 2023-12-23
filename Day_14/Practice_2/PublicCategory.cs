using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class PublicCategory : ICategories
    {
        public enum PublicCategories
        {
            Bus,
            Train
        }


        public void ShowVehiclesInCategory()
        {
            Console.WriteLine(PublicCategories.Bus);
            Console.WriteLine(PublicCategories.Train);
            string choise = Console.ReadLine();
            ChooseVehicle(choise.ToLower());
        }

        public void ChooseVehicle(string name)
        {
            if (name == PublicCategories.Bus.ToString().ToLower())
            {
                Bus bus = new Bus();
                bus.ShowName();
                bus.Drive();
            }
            else if (name == PublicCategories.Train.ToString().ToLower())
            {
                Train train = new Train();
                train.ShowName();
                train.Drive();
            }
        }
    }
}
