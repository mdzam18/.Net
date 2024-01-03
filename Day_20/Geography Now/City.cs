namespace Geography_Now
{
    internal class City : GeographicEntity
    {

        public City(string name, decimal area, int population, bool isCapital, string countryName) : base(name)
        {
            Name = name;
            Area = area;
            Population = population;
            IsCapital = isCapital;
            CountryName = countryName;
        }

        public bool IsCapital { get; }

        public string CountryName { get; }

        public override decimal Area { get; }

        public override int Population { get; }

    }
}