namespace ExceptionPractice
{
    internal class IBAN
    {
        decimal _Balance;
        string _IBAN;
        decimal _Limit;

        const int IBANLength = 22;

        public IBAN(string iban, decimal balance, decimal limit)
        {
            _IBAN = iban;
            CheckIBAN();
            if (balance < 0 || limit < 0)
            {
                throw new NegativeAmountException();
            }
            _Balance = balance;
            _Limit = limit;
        }

        private void CheckIBAN()
        {
            if (_IBAN.Length != IBANLength)
            {
                throw new InvalidIBANException("Invalid length");
            }
            if (!_IBAN.StartsWith("GE"))
            {
                throw new InvalidIBANException("Invalid country code");
            }
        }

        public decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new NegativeAmountException();
                }
                _Balance = value;
            }
        }

        public decimal Limit
        {
            get
            {
                return _Limit;
            }
            set
            {
                if (value < 0)
                {
                    throw new NegativeAmountException();
                }
                _Limit = value;
            }
        }

    }
}
