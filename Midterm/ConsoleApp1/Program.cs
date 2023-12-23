namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int[] arr = new int[5] { -1, 2, 3, 4, 6 };
            ShowPairs(number, arr);
            int [] arr2 = new int[] { 7, 4, 3, 2, 6, 5, 8 };
            Console.WriteLine(FindMissedElement(arr2));
            int number2 = 0;
            Console.WriteLine(ConvertToBinaryNumber(number2));
            AskForDirectoryPath();
        }

        private static void AskForDirectoryPath()
        {
            Console.WriteLine("To turn off program type \"exit\" otherwise enter the directory path");
            while (true)
            {
                Console.WriteLine("Enter path: ");
                string path = Console.ReadLine();
                Console.WriteLine();
                if (path == null || path == "exit")
                {
                    break;
                }
                if (Directory.Exists(path))
                {
                    FindDirectory(path);
                }
                else
                {
                    Console.WriteLine("Directory does not exists");
                }
            }
        }

        private static void FindDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }
            string[] files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                FindDirectory(directory);
            }
        }

        private static string ConvertToBinaryNumber(int number)
        {
            string result = "";
            while (true)
            {
                int remainder = number % 2;
                result = remainder + result;
                number = number / 2;
                if (number == 0)
                {
                    break;
                }
            }
            return result;
        }

        private static int FindMissedElement(int[] arr)
        {
            int sum = 0;
            int sumWithoutMissingElement = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                sumWithoutMissingElement = sumWithoutMissingElement + i + 1;
            }
            int result = arr.Length - (sum - sumWithoutMissingElement) + 1;
            return result;
        }

        private static void ShowPairs(int number, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int elem = arr[i];
                int n = number - elem;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == n && n > elem)
                    {
                        Console.WriteLine(elem + " " + n);
                    }
                }
            }
        }

    }
}
