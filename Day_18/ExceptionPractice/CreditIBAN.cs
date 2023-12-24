namespace ExceptionPractice
{
    internal class CreditIBAN : IBAN
    {

        public CreditIBAN(string iban, decimal balance, decimal limit) : base(iban, balance, limit)
        {

        }

        public void DepositMoney(decimal amount)
        {
            if (amount > Limit)
            {
                throw new LimitIsIncreasedException();
            }
            if (amount < 0)
            {
                throw new NegativeAmountException();
            }
            Balance += amount;
        }

    }
}
