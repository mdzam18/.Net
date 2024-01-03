namespace Geography_Now
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string logFilePath = "C:\\Users\\Mariami\\source\\repos\\MariamDzamukashvili\\Day_20\\Geography Now\\Logs.txt";
            string citiesFilePath = "C:\\Users\\Mariami\\source\\repos\\MariamDzamukashvili\\Day_20\\Geography Now\\Cities.txt";
            using (StreamWriter writer = new StreamWriter(logFilePath))
            {
                writer.Write("");
            }
            GeographyNow geography = new GeographyNow(logFilePath, citiesFilePath);
            geography.ShowSearchingOptions();
        }

    }
}