using System.Diagnostics;

namespace Practice_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ElectricCar car = new ElectricCar();
            car.BatteryLevel = 5;
            car.Model = "BMW";
            List<ElectricCar> list = new List<ElectricCar>();
            ElectricCar car2 = new ElectricCar();
            car2.BatteryLevel = 15;
            car2.Model = "Ferrari";
            ElectricCar car3 = new ElectricCar();
            car3.BatteryLevel = 30;
            car3.Model = "Tesla";
            list.Add(car);
            list.Add(car2);
            list.Add(car3);
            await ChargeAllCarsAsync(list);
        }

        public async static Task ChargeAllCarsAsync(IEnumerable<ElectricCar> cars)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Start Charging");
            sw.Start();
            Task[] tasks = new Task[cars.Count()];
            for (int i = 0; i < cars.Count(); i++)
            {
                ElectricCar car = cars.ElementAt(i);
                tasks[i] = ChargeCarAsync(car);
            }
            await Task.WhenAll(tasks);

            Console.WriteLine("Charging Time For All Cars {0}", sw.ElapsedMilliseconds / 1000);
            sw.Stop();
        }

        private async static Task ChargeCarAsync(ElectricCar car)
        {
            await car.ChargeAsync();
        }

    }
}