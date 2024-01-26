namespace ExceptionPractice
{
    internal static class ATM
    {

        public static void WithdrawMoney(decimal amount, DebitIBAN iban)
        {
            iban.WithdrawMoney(amount);
        }

        public static void DepositMoney(decimal amount, CreditIBAN iban)
        {
            iban.DepositMoney(amount);
        }

    }
}
