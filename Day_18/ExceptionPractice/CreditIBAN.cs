namespace ExceptionPractice
{
    internal class CreditIBAN : IBAN
    {

        public CreditIBAN(string iban, decimal balance, decimal limit) : base(iban, balance, limit)
        {

        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0 || Limit < 0)
            {
                throw new NegativeAmountException();
            }
            if (amount > Limit)
            {
                throw new LimitIsIncreasedException();
            }
            Balance += amount;
        }

    }
}
