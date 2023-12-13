namespace Practice_2
{
    internal class Tank : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Tank is driving");
        }

        public void ShowName()
        {
            Console.WriteLine("Tank");
        }
    }
}
