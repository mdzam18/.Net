namespace TestingTime
{
    class QuizMissingFieldException : Exception
    {

        public QuizMissingFieldException() : base("Field is missing in the quiz") { }

    }
}
