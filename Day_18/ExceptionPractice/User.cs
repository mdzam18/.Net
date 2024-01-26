namespace ExceptionPractice
{
    internal class User
    {

        string _FullName;
        DebitIBAN? _DebitIBAN;
        CreditIBAN? _CreditIBAN;

        public User(string fullName, DebitIBAN? debitIBAN, CreditIBAN? creditIBAN)
        {
            _FullName = fullName;
            _DebitIBAN = debitIBAN;
            _CreditIBAN = creditIBAN;
        }

        public DebitIBAN? DebitIBAN
        {
            get
            {
                return _DebitIBAN;
            }
            set
            {
                _DebitIBAN = value;
            }
        }

        public CreditIBAN? CreditIBAN
        {
            get
            {
                return _CreditIBAN;
            }
            set
            {
                _CreditIBAN = value;
            }
        }

        public string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }

    }
}
