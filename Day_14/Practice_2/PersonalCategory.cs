using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class PersonalCategory : ICategories
    {
        public enum PersonalCategories
        {
            Jeep
        }


        public void ShowVehiclesInCategory()
        {
            Console.WriteLine(PersonalCategories.Jeep);
            string choise = Console.ReadLine();
            ChooseVehicle(choise.ToLower());
        }

        public void ChooseVehicle(string name)
        {
            if (name == PersonalCategories.Jeep.ToString().ToLower())
            {
                Jeep jeep = new Jeep();
                jeep.ShowName();
                jeep.Drive();
            }
        }
    }
}
