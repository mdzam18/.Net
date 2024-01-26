namespace Geography_Now
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            currentDirectory = currentDirectory.Substring(0, currentDirectory.IndexOf("bin"));
            string logFilePath = currentDirectory + "Logs.txt";
            string citiesFilePath = currentDirectory + "Cities.txt";
            using (StreamWriter writer = new StreamWriter(logFilePath))
            {
                writer.Write("");
            }
            GeographyNow geography = new GeographyNow(logFilePath, citiesFilePath);
            geography.ShowSearchingOptions();
        }

    }
}