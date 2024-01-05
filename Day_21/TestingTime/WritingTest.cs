using System.Text;

namespace TestingTime
{
    static class WritingTest
    {

        public static void StartWritingTest(string testFilePath)
        {
            Quiz quiz = GetQuiz();
            int totalNumberOfQuestions = GetTotalNumberOfQuestions(testFilePath);

            using (StreamWriter writer = new StreamWriter(testFilePath, true))
            {
                writer.WriteLine();
                StringBuilder quizAsString = new StringBuilder();
                quizAsString.Append((totalNumberOfQuestions + 1) + ")" + quiz.Question + "|");
                List<String> possibleAnswers = quiz.PossibleAnswers;
                int count = possibleAnswers.Count;
                for (int i = 0; i < count; i++)
                {
                    if (i != count - 1)
                    {
                        quizAsString.Append(possibleAnswers[i] + "|");
                    }
                    else
                    {
                        quizAsString.Append(possibleAnswers[i]);
                    }
                }
                writer.Write(quizAsString.ToString());
            }
        }

        private static int GetTotalNumberOfQuestions(string testFilePath)
        {
            int totalNumberOfQuestions = 0;
            using (StreamReader reader = new StreamReader(testFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        totalNumberOfQuestions++;
                    }
                }
            }
            return totalNumberOfQuestions;
        }

        private static Quiz GetQuiz()
        {
            Console.WriteLine("Enter question: ");
            Quiz quiz = new Quiz();
            string question = Console.ReadLine();
            quiz.Question = question;
            Console.WriteLine("Enter 4 answers separating Enter button, if the answer is correct select it with ‘*’");
            List<string> possibleAnswers = new List<string>();
            quiz.RightAnswer = -1;
            for (int i = 0; i < 4; i++)
            {
                string option = (char)('a' + i) + ")";
                Console.Write("Enter option {0}", option);
                string possibleAnswer = Console.ReadLine();
                possibleAnswers.Add(option + possibleAnswer);
                if (possibleAnswer.Substring(possibleAnswer.Length - 1) == "*")
                {
                    quiz.RightAnswer = i;
                }
            }
            if (quiz.RightAnswer == -1)
            {
                throw new IncorrectlyFormedPossibleAnswerException("Right answer is not selected in the possible answers.");
            }
            quiz.PossibleAnswers = possibleAnswers;
            return quiz;
        }

    }
}