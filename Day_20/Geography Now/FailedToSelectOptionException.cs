namespace Geography_Now
{
    internal class FailedToSelectOptionException : Exception
    {

        public FailedToSelectOptionException(string filePath) : base("Failed to select searching option")
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Failed to select searching option");
            }
        }

    }
}
