namespace Geography_Now
{
    internal class FailedToParseException : Exception
    {

        public FailedToParseException(string message, string filePath) : base(String.Format("Failed to parse, {0}", message))
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine(String.Format("Failed to parse, {0}", message));
            }
        }

    }
}
