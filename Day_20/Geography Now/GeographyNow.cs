namespace Geography_Now
{
    internal class GeographyNow
    {
        readonly string LogFilePath;
        readonly string CitiesFilePath;

        public GeographyNow(string logFilePath, string citiesFilePath)
        {
            LogFilePath = logFilePath;
            CitiesFilePath = citiesFilePath;
            FileReader fileReader = new FileReader(LogFilePath, CitiesFilePath);
            Tuple<Dictionary<string, City>, Dictionary<string, Country>> citiesAndCountries = fileReader.ReadFileOfCities();
            Cities = citiesAndCountries.Item1;
            Countries = citiesAndCountries.Item2;
        }

        public Dictionary<string, City> Cities { get; set; }

        public Dictionary<string, Country> Countries { get; set; }

        private void GetInfoByCityName(string cityName)
        {
            if (!Cities.ContainsKey(cityName))
            {
                throw new GeographyEntityNotFoundException(String.Format("City {0}", cityName), LogFilePath);
            }
            City city = Cities[cityName];
            Console.WriteLine("city name: {0}", city.Name.Remove(1).ToUpper() + city.Name.Substring(1));
            Console.WriteLine("area: {0}", city.Area);
            Console.WriteLine("population: {0}", city.Population);
            Console.WriteLine("country name: {0}", city.CountryName.Remove(1).ToUpper() + city.CountryName.Substring(1));
            if (city.IsCapital)
            {
                Console.WriteLine("is capital");
            }
        }

        private void GetInfoByCountryName(string countryName)
        {
            if (!Countries.ContainsKey(countryName))
            {
                throw new GeographyEntityNotFoundException(String.Format("Country {0}", countryName), LogFilePath);
            }
            Country country = Countries[countryName];
            Console.WriteLine("country name: {0}", country.Name.Remove(1).ToUpper() + country.Name.Substring(1));
            Console.WriteLine("area: {0}", country.Area);
            Console.WriteLine("population: {0}", country.Population);
            ShowCitiesOfTheCountry(country);
        }

        private void ShowCitiesOfTheCountry(Country country)
        {
            List<City> cities = country.Cities;
            Console.Write("Cities: ");
            foreach (City city in cities)
            {
                Console.Write("{0} ", city.Name.Remove(1).ToUpper() + city.Name.Substring(1));
                if (city.IsCapital)
                {
                    Console.Write("(is capital) ");
                }
            }
        }

        public void ShowSearchingOptions()
        {
            Console.WriteLine("1. Search Country");
            Console.WriteLine("2. Search City");
            Console.WriteLine("\nEnter digit '1' or '2'");
            int choise;
            if (!int.TryParse(Console.ReadLine(), out choise))
            {
                throw new FailedToParseException("Invalid integer.", LogFilePath);
            }
            if (choise == 1)
            {
                Console.Write("Enter country: ");
                string countryName = Console.ReadLine();
                GetInfoByCountryName(countryName.ToLower());
            }
            else if (choise == 2)
            {
                Console.Write("Enter city: ");
                string cityName = Console.ReadLine();
                GetInfoByCityName(cityName.ToLower());
            }
            else
            {
                throw new FailedToSelectOptionException(LogFilePath);
            }
        }

    }
}