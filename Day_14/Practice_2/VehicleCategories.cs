namespace Practice_2
{
    internal class VehicleCategories
    {

        public enum Categories
        {
            Military,
            Public,
            Personal,
            Sport
        }

        public void ShowCategories()
        {
            Console.WriteLine(Categories.Military);
            Console.WriteLine(Categories.Public);
            Console.WriteLine(Categories.Personal);
            Console.WriteLine(Categories.Sport);
        }


        public void ChooseCategory(String name)
        {
            name = name.ToLower();
            if (name == Categories.Military.ToString().ToLower())
            {
                MilitaryCategory militaryCategory = new MilitaryCategory();
                militaryCategory.ShowVehiclesInCategory();
            }
            else if (name == Categories.Public.ToString().ToLower())
            {
                PublicCategory publicCategory = new PublicCategory();
                publicCategory.ShowVehiclesInCategory();
            }
            else if (name == Categories.Personal.ToString().ToLower())
            {
                PersonalCategory personalCategory = new PersonalCategory();
                personalCategory.ShowVehiclesInCategory();
            }
            else if (name == Categories.Sport.ToString().ToLower())
            {
                SportCategory sportCategory = new SportCategory();
                sportCategory.ShowVehiclesInCategory();
            }
        }


    }
}
