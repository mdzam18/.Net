namespace Delegates
{
    class ConsolidatedLogging
    {

        public static void LogMessage(string message)
        {
            Action<string> LogMessageDelegate = (s) => PrintLogMessage(s);
            LogMessageDelegate += (s) => WriteLogMessageInFile(s);

            LogMessageDelegate(message);
        }

        private static void PrintLogMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void WriteLogMessageInFile(string message)
        {
            using (StreamWriter sw = new StreamWriter(message))
            {
                sw.WriteLine(message);
            }
        }

    }
}