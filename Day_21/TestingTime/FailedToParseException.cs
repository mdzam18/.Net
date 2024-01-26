namespace TestingTime
{
    class FailedToParseException : Exception
    {

        public FailedToParseException(string message) : base(String.Format("Failed to parse input. {0}", message)) { }

    }
}