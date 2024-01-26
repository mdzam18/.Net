namespace Geography_Now
{
    internal class InvalidInputInCitiesFileException : Exception
    {

        public InvalidInputInCitiesFileException(string filePath) : base("Invalid input in cities file")
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Invalid input in cities file");
            }
        }

    }
}