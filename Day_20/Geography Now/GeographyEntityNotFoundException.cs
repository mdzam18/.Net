namespace Geography_Now
{
    internal class GeographyEntityNotFoundException : Exception
    {

        public GeographyEntityNotFoundException(string message, string filePath) : base(String.Format("{0} not found", message))
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine(String.Format("{0} not found", message));
            }
        }

    }
}
