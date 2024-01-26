namespace TestingTime
{
    class IncorrectlyFormedPossibleAnswerException : Exception
    {

        public IncorrectlyFormedPossibleAnswerException(string message) : base(String.Format("Possible answer is formed incorrectly. {0}", message)) { }

    }
}