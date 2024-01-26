namespace ExceptionPractice
{
    internal class NotEnoughBalanceException : Exception
    {

        public NotEnoughBalanceException() : base("Balance is not enough") { }

    }
}
