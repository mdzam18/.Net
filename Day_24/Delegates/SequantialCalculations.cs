namespace Delegates
{
    class SequantialCalculations
    {

        public static void MakeSequantialCalculations(decimal n, decimal m)
        {
            Func<decimal, decimal, decimal> MathOperation = (n, m) => AddNumbers(n, m);
            MathOperation += (n, m) => MultiplyNumbers(n, m);
            MathOperation += (n, m) => SubtractNumbers(n, m);
            MathOperation += (n, m) => DivisionNumbers(n, m);

            var list = MathOperation.GetInvocationList();
            foreach (Func<decimal, decimal, decimal> method in list)
            {
                Console.WriteLine(method(n, m));
            }
        }

        private static decimal AddNumbers(decimal n, decimal m)
        {
            return n + m;
        }

        private static decimal MultiplyNumbers(decimal n, decimal m)
        {
            return n * m;
        }

        private static decimal SubtractNumbers(decimal n, decimal m)
        {
            return n - m;
        }

        private static decimal DivisionNumbers(decimal n, decimal m)
        {
            try
            {
                return n / m;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

    }
}