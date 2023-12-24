namespace ExceptionPractice
{
    internal class DebitIBAN : IBAN
    {

        public DebitIBAN(string iban, decimal balance, decimal limit) : base(iban, balance, limit)
        {
            
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount > Limit)
            {
                throw new LimitIsIncreasedException();
            }
            if (amount < 0)
            {
                throw new NegativeAmountException();
            }
            if (Balance < amount)
            {
                throw new NotEnoughBalanceException();
            }
            else
            {
                Balance -= amount;
            }
        }

    }
}
