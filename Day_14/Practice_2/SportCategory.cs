using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class SportCategory : ICategories
    {

        public enum SportCategories
        {
            FormulaOne,
            Rally
        }


        public void ShowVehiclesInCategory()
        {
            Console.WriteLine(SportCategories.FormulaOne);
            Console.WriteLine(SportCategories.Rally);
            string choise = Console.ReadLine();
            ChooseVehicle(choise.ToLower());
        }

        public void ChooseVehicle(string name)
        {
            if (name == SportCategories.FormulaOne.ToString().ToLower())
            {
                FormulaOne formulaOne = new FormulaOne();
                formulaOne.ShowName();
                formulaOne.Drive();
            }
            else if (name == SportCategories.Rally.ToString().ToLower())
            {
                Rally rail = new Rally();
                rail.ShowName();
                rail.Drive();
            }
        }
    }
}
