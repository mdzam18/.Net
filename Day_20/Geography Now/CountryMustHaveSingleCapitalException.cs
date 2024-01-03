namespace Geography_Now
{
    internal class CountryMustHaveSingleCapitalException : Exception
    {

        public CountryMustHaveSingleCapitalException(string message1, string filePath) : base(String.Format("{0} has already a capital", message1))
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(String.Format("{0} has already a capital", message1));
            }
        }

    }
}
