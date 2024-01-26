namespace TestingTime
{
    class Program
    {

        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            currentDirectory = currentDirectory.Substring(0, currentDirectory.IndexOf("bin"));
            Exam.ShowExamOptions(currentDirectory + "Tests.txt");
        }

    }
}