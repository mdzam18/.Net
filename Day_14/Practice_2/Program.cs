namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleCategories categories = new VehicleCategories();
            Console.WriteLine("Vehicle Categories");
            categories.ShowCategories();
            Console.Write("Coose Category: ");
            string choise = Console.ReadLine();
            categories.ChooseCategory(choise);
        }
    }
}
