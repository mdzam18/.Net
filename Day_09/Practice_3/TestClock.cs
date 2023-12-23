namespace Practice_3
{
    internal class TestClock
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            int hours;
            int minutes;
            int seconds;
            Console.Write("Enter hours: ");
            bool b1 = int.TryParse(Console.ReadLine(), out hours);
            Console.Write("Enter minutes: ");
            bool b2 = int.TryParse(Console.ReadLine(), out minutes);
            Console.Write("Enter seconds: ");
            bool b3 = int.TryParse(Console.ReadLine(), out seconds);
            if (b1 && b2 && b3)
            {
                clock.Hours = hours;
                clock.Minutes = minutes;
                clock.Seconds = seconds;
                clock.GetCurrentTime();
                clock.AddSecond();
                clock.AddSecond();
                clock.AddSecond();
                clock.AddSecond();
                clock.GetCurrentTime();
                clock.AddSecond();
                clock.AddSecond();
                clock.AddSecond();
                clock.AddMinute();
                clock.GetCurrentTime();
                clock.SubtractHour();
                clock.GetCurrentTime();
                clock.SubtractMinute();
                clock.SubtractSecond();
                clock.GetCurrentTime();
            }
        }
    }
}
