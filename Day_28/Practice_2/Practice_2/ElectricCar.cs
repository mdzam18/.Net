using System.Diagnostics;

namespace Practice_2
{

    class ElectricCar
    {

        public int BatteryLevel { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public async Task ChargeAsync()
        {
            Stopwatch sw = Stopwatch.StartNew();
            while (true)
            {
                if (sw.ElapsedMilliseconds >= 200000)
                {
                    Console.WriteLine("ToTal charging time for {0} is {1}", Model, sw.ElapsedMilliseconds / 1000);
                    break;
                }
                if (BatteryLevel >= 100)
                {
                    Console.WriteLine("ToTal charging time for {0} is {1}", Model, sw.ElapsedMilliseconds / 1000);
                    break;
                }
                await Task.Delay(10000);
                BatteryLevel += 5;
            }
            sw.Stop();
        }

    }
}