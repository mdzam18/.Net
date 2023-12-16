namespace Extensions_Practices
{
    public static class DateTimeExtension
    {

        public static string ConvertToString(this DateTime date)
        {
            return string.Format("{0}/{1}/{2} {3}:{4}:{5}:{6}", date.Day, date.Month, date.Year, date.Hour, date.Minute, date.Second, date.Millisecond);
        }

        public static bool IsDateInRange(this DateTime date, DateTime date1, DateTime date2)
        {
            if (date >= date1 && date <= date2)
            {
                return true;
            }
            return false;
        }

        public static int GetAge(this DateTime date)
        {
            int birthYear = date.Year;
            int birthMonth = date.Month;
            int birthDay = date.Day;
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
            int yearDiff = currentYear - birthYear;
            if (currentMonth >= birthMonth)
            {
                if (currentDay >= birthDay)
                {
                    return yearDiff;
                }
            }
            return yearDiff - 1;
        }

    }
}
