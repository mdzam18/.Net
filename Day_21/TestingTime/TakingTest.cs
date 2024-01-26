namespace TestingTime
{
    static class TakingTest
    {
        static List<Quiz> _Quizzes;

        private static void ReadQuizzesFromFile(string testFilePath)
        {
            _Quizzes = new List<Quiz>();
            using (StreamReader sr = new StreamReader(testFilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Quiz quiz = new Quiz();
                    if (line == "")
                    {
                        continue;
                    }
                    string[] questionAndPossibleAnswers = line.Split('|');
                    if (questionAndPossibleAnswers.Length != 5)
                    {
                        throw new QuizMissingFieldException();
                    }
                    string question = questionAndPossibleAnswers[0];
                    List<string> possibleAnswers = new List<string>();
                    quiz.RightAnswer = -1;
                    for (int i = 1; i < questionAndPossibleAnswers.Length; i++)
                    {
                        string possibleAnswer = questionAndPossibleAnswers[i];
                        CheckPossibleAnswersStructure(possibleAnswer);
                        if (possibleAnswer.Substring(possibleAnswer.Length - 1) == "*")
                        {
                            quiz.RightAnswer = possibleAnswers.Count();
                            possibleAnswer = possibleAnswer.Substring(0, possibleAnswer.Length - 1);
                        }
                        possibleAnswers.Add(possibleAnswer);
                    }
                    if (quiz.RightAnswer == -1)
                    {
                        throw new IncorrectlyFormedPossibleAnswerException("Right answer is not selected in possible answers.");
                    }
                    quiz.Question = question;
                    quiz.PossibleAnswers = possibleAnswers;
                    _Quizzes.Add(quiz);
                }
            }
        }

        private static void CheckPossibleAnswersStructure(string possibleAnswer)
        {
            if (possibleAnswer.Length < 2)
            {
                throw new IncorrectlyFormedPossibleAnswerException("");
            }
            char choise = possibleAnswer[0];
            if (choise - 'a' < 0 || choise - 'a' > 3 || possibleAnswer[1] != ')')
            {
                throw new IncorrectlyFormedPossibleAnswerException("Option letters must be from 'a' to 'd'");
            }
        }

        public static void StartTakingTest(string testFilePath)
        {
            ReadQuizzesFromFile(testFilePath);
            int totalScore = 0;
            foreach (Quiz quiz in _Quizzes)
            {
                string question = quiz.Question;
                List<string> possibleAnswers = quiz.PossibleAnswers;
                int rightAnswer = quiz.RightAnswer;
                Console.WriteLine("\n" + question);
                PrintPossibleAnswers(possibleAnswers);
                Console.Write("Your answer: ");
                char chosenAnswer;
                if (char.TryParse(Console.ReadLine(), out chosenAnswer))
                {
                    int choise = chosenAnswer - 'a';
                    if (choise >= 0 && choise < possibleAnswers.Count)
                    {
                        if (rightAnswer == choise)
                        {
                            totalScore++;
                        }
                        Console.WriteLine("Right answer is: {0}", possibleAnswers[rightAnswer]);
                    }
                    else
                    {
                        throw new SelectedIncorrectLetterException();
                    }
                }
                else
                {
                    throw new FailedToParseException("Invalid integer");
                }
            }
            Console.WriteLine("\nYour result is: {0}/{1}.", totalScore, _Quizzes.Count);
        }

        private static void PrintPossibleAnswers(List<string> possibleAnswers)
        {
            foreach (string possibleAnswer in possibleAnswers)
            {
                Console.WriteLine(possibleAnswer);
            }
            Console.WriteLine("\nSelect a letter from 'a' to 'd'");
        }

    }
}