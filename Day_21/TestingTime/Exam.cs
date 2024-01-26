namespace TestingTime
{
    static class Exam
    {

        public static void ShowExamOptions(string testFilePath)
        {
            Console.WriteLine("1) Start Test");
            Console.WriteLine("2) Add Test");
            Console.WriteLine("Select an option by entering the digit '1' or '2'");
            int choise;
            if (int.TryParse(Console.ReadLine(), out choise))
            {
                if (choise == 1)
                {
                    TakingTest.StartTakingTest(testFilePath);
                }
                else if (choise == 2)
                {
                    WritingTest.StartWritingTest(testFilePath);
                }
                else
                {
                    throw new SelectedInvalidDigitException();
                }
            }
            else
            {
                throw new FailedToParseException("Invalid integer.");
            }
        }

    }
}