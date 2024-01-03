namespace Geography_Now
{
    internal class EmptyStringException : Exception
    {

        public EmptyStringException(string filePath) : base("Name can not be an empty string")
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name can not be an empty string");
            }
        }

    }
}
