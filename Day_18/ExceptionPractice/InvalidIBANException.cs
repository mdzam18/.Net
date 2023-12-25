namespace ExceptionPractice
{
    internal class InvalidIBANException : Exception
    {

        public InvalidIBANException(string message) : base(string.Format("Invalid IBAN. {0}", message)) { }

    }
}
