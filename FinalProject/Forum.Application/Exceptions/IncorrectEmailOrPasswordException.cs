namespace Forum.Application.Exceptions
{
    public class IncorrectEmailOrPasswordException : Exception
    {
        public string Code = "IncorrectEmailOrPassword";

        public IncorrectEmailOrPasswordException(string message) : base(message) { }

    }
}
