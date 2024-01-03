namespace Geography_Now
{
    internal class NotPositiveNumberException : Exception
    {

        public NotPositiveNumberException(string filePath, string message) : base(String.Format("{0} must be a positive number", message))
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine(String.Format("{0} must be a positive number", message));
            }
        }

    }
}