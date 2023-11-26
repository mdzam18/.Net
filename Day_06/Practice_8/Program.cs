namespace Practice_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;
            int number = EnterNumber(out isValid);
            if (!isValid)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            ShowNumberAsTensPowersSum(number);
        }

        private static void ShowNumberAsTensPowersSum(int number)
        {
            string result = "";
            int power = 0;
            int curr = number;
            while (curr != 0)
            {
                int remainder = curr % 10;
                curr = curr / 10;
                if (curr == number / 10)
                {
                    result = remainder + " * 10^" + power + result;
                }
                else
                {
                    result = remainder + " * 10^" + power + " + " + result;
                }
                power++;
            }
            Console.WriteLine(number + " = " + result);
        }

        private static int EnterNumber(out bool isValid)
        {
            Console.Write("Enter a positive number: ");
            int number = 0;
            isValid = int.TryParse(Console.ReadLine(), out number);
            if (number <= 0)
            {
                isValid = false;
            }
            return number;
        }

    }
}
