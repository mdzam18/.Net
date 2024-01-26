namespace Geography_Now
{
    internal class Country : GeographicEntity
    {

        public Country(string name, List<City> cities) : base(name)
        {
            Cities = cities;
        }

        public bool HasCapital { get; set; }

        private decimal GetArea()
        {
            decimal area = 0;
            foreach (City city in Cities)
            {
                area += city.Area;
            }
            return area;
        }

        private int GetPopulation()
        {
            int population = 0;
            foreach (City city in Cities)
            {
                population += city.Population;
            }
            return population;
        }

        public List<City> Cities { get; set; }

        public override decimal Area
        {
            get
            {
                return GetArea();
            }
        }

        public override int Population
        {
            get
            {
                return GetPopulation();
            }
        }

    }
}