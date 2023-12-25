namespace ExceptionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DebitIBAN debitIBAN = new DebitIBAN("GE12345678912345678912", 100, 20);
            CreditIBAN creditIBAN = new CreditIBAN("GE12345678912345678712", 200, 40);
            User user = new User("Tom Hanks", debitIBAN, creditIBAN);
            ATM.WithdrawMoney(20, debitIBAN);
            Console.WriteLine(String.Format("balance of user {0} is: {1}", user.FullName, debitIBAN.Balance));

            ATM.DepositMoney(35, creditIBAN);
            Console.WriteLine(String.Format("balance of user {0} is: {1}", user.FullName, creditIBAN.Balance));

            CheckExceptionMethods();
        }

        private static void CheckExceptionMethods()
        {
            Exception third = new Exception("third");
            Exception second = new Exception("second", third);
            Exception first = new Exception("first", second);
            Console.WriteLine(ExceptionMethods.GetLastInnerExMessage(first));

            Console.WriteLine(ExceptionMethods.GetAllInnerExMessageTogether(first));
        }

    }
}
