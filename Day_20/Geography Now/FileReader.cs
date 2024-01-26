using System.Globalization;

namespace Geography_Now
{
    class FileReader
    {
        readonly string CitiesFilePath;
        readonly string LogFilePath;

        public FileReader(string logFilePath, string citiesFilePath)
        {
            LogFilePath = logFilePath;
            CitiesFilePath = citiesFilePath;
        }

        public Tuple<Dictionary<string, City>, Dictionary<string, Country>> ReadFileOfCities()
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();
            Dictionary<string, Country> countries = new Dictionary<string, Country>();
            using (StreamReader reader = new StreamReader(CitiesFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] info = line.Split("|", StringSplitOptions.RemoveEmptyEntries);
                    if (line == "")
                    {
                        continue;
                    }
                    if (info.Length < 5)
                    {
                        throw new InvalidInputInCitiesFileException(LogFilePath);
                    }
                    City? city = CreateCityObject(cities, info);
                    if (city != null)
                    {
                        CreateCountryObject(countries, city);
                    }
                }
            }
            return new Tuple<Dictionary<string, City>, Dictionary<string, Country>>(cities, countries);
        }

        private City? CreateCityObject(Dictionary<string, City> cities, string[] info)
        {
            string name = info[0].ToLower();
            if (name == "")
            {
                throw new EmptyStringException(LogFilePath);
            }
            if (cities.ContainsKey(name))
            {
                return null;
            }
            decimal area = GetAreaConsideringCultureOfCountry(info[1]);
            if (area <= 0)
            {
                throw new NotPositiveNumberException(LogFilePath, "Area");
            }
            int population;
            if (!int.TryParse(info[2], out population))
            {
                throw new FailedToParseException("Invalid integer.", LogFilePath);
            }
            if (population <= 0)
            {
                throw new NotPositiveNumberException(LogFilePath, "Population");
            }
            bool isCapital;
            if (!bool.TryParse(info[3], out isCapital))
            {
                throw new FailedToParseException("Invalid boolean.", LogFilePath);
            }
            string countryName = info[4].ToLower();
            if (countryName == "")
            {
                throw new EmptyStringException(LogFilePath);
            }
            City city = new City(name, area, population, isCapital, countryName);
            cities.Add(name, city);
            return city;
        }

        private void CreateCountryObject(Dictionary<string, Country> countries, City city)
        {
            string countryName = city.CountryName;
            if (countries.ContainsKey(countryName))
            {
                Country country = countries[countryName];
                List<City> citiesListInCountry = country.Cities;
                if (city.IsCapital)
                {
                    if (country.HasCapital)
                    {
                        throw new CountryMustHaveSingleCapitalException(countryName, LogFilePath);
                    }
                    else
                    {
                        country.HasCapital = true;
                    }
                }
                citiesListInCountry.Add(city);
                country.Cities = citiesListInCountry;
                countries[countryName] = country;
            }
            else
            {
                List<City> citiesListInCountry = new List<City> { city };
                Country country = new Country(countryName, citiesListInCountry);
                country.HasCapital = false;
                if (city.IsCapital)
                {
                    country.HasCapital = true;
                }
                countries.Add(countryName, country);
            }
        }

        private decimal GetAreaConsideringCultureOfCountry(string value)
        {
            CultureInfo customCulture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ",";
            if (decimal.TryParse(value, NumberStyles.Number, customCulture, out decimal result))
            {
                return result;
            }
            else
            {
                throw new FailedToParseException("Invalid decimal.", LogFilePath);
            }
        }

    }
}