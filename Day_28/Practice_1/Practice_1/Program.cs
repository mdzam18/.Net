namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateTasks();
        }

        private static void CreateTasks()
        {
            var cancelationToken = new CancellationTokenSource();
            Task[] writingTasks = new Task[10];
            string directory = Directory.GetCurrentDirectory();
            directory = directory.Substring(0, directory.IndexOf("bin"));
            for (int i = 0; i < 10; i++)
            {
                int index = i + 1;
                writingTasks[i] = Task.Run(async () =>
                {
                    using (StreamWriter sw = new StreamWriter(directory + index + ".txt"))
                    {
                        int n = 1;
                        while (true)
                        {
                            if (cancelationToken.IsCancellationRequested)
                            {
                                break;
                            }
                            sw.WriteLine("Task {0}", n);
                            sw.Flush();
                            await Task.Delay(index * 100);
                            n++;
                        }
                    }
                }, cancelationToken.Token);
            }
            Task inputTask = Task.Run(() =>
            {
                Console.ReadKey();
                cancelationToken.Cancel();
            });
            Task.WaitAll(inputTask);
        }

    }
}