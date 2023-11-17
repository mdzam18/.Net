namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your day of birth:");
            int day = 0;
            bool b = int.TryParse(Console.ReadLine(), out day);
            if (b && day > 0 && day <= 31)
            {
                Console.WriteLine("Enter your month of birth:");
                string month = Console.ReadLine().ToLower();
                string result = "";
                switch (month)
                {
                    case "january":
                        if (day < 20)
                        {
                            result = "Capricornus";
                        }
                        else
                        {
                            result = "Aquarius";
                        }
                        break;
                    case "february":
                        if (day < 19)
                        {
                            result = "Aquarius";
                        }
                        else if (day <= 29)
                        {
                            result = "Pisces";
                        }
                        else
                        {
                            Console.WriteLine("Invalid date");
                            return;
                        }
                        break;
                    case "march":
                        if (day < 21)
                        {
                            result = "Pisces";
                        }
                        else
                        {
                            result = "Aries";
                        }
                        break;
                    case "april":
                        if (day < 20)
                        {
                            result = "Aries";
                        }
                        else if (day == 31)
                        {
                            Console.WriteLine("Invalid date");
                            return;
                        }
                        else
                        {
                            result = "Taurus";
                        }
                        break;
                    case "may":
                        if (day < 21)
                        {
                            result = "Taurus";
                        }
                        else
                        {
                            result = "Gemini";
                        }
                        break;
                    case "june":
                        if (day < 22)
                        {
                            result = "Gemini";
                        }
                        else if (day == 31)
                        {
                            Console.WriteLine("Invalid date");
                            return;
                        }
                        else
                        {
                            result = "Cancer";
                        }
                        break;
                    case "july":
                        if (day < 23)
                        {
                            result = "Cancer";
                        }
                        else
                        {
                            result = "Leo";
                        }
                        break;
                    case "august":
                        if (day < 23)
                        {
                            result = "Leo";
                        }
                        else
                        {
                            result = "Virgo";
                        }
                        break;
                    case "september":
                        if (day < 23)
                        {
                            result = "Virgo";
                        }
                        else if (day == 31)
                        {
                            Console.WriteLine("Invalid date");
                            return;
                        }
                        else
                        {
                            result = "Libra";
                        }
                        break;
                    case "october":
                        if (day < 24)
                        {
                            result = "Libra";
                        }
                        else
                        {
                            result = "Scorpius";
                        }
                        break;
                    case "november":
                        if (day < 22)
                        {
                            result = "Scorpius";
                        }
                        else if (day == 31)
                        {
                            Console.WriteLine("Invalid date");
                            return;
                        }
                        else
                        {
                            result = "Sagittarius";
                        }
                        break;
                    case "december":
                        if (day < 22)
                        {
                            result = "Sagittarius";
                        }
                        else
                        {
                            result = "Capricornus";
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid month");
                        return;
                }
                month = month.ToCharArray()[0].ToString().ToUpper() + month.Substring(1);
                Console.WriteLine(day + " " + month + " is " + result);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
          
