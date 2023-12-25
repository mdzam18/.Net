using System.Text;

namespace ExceptionPractice
{
    internal static class ExceptionMethods
    {

        public static string GetLastInnerExMessage(Exception ex)
        {
            string result = "";
            while (true)
            {
                if (ex == null)
                {
                    return result;
                }
                result = ex.Message;
                ex = ex.InnerException;
            }
        }

        public static string GetAllInnerExMessageTogether(Exception ex)
        {
            StringBuilder result = new StringBuilder();
            while (true)
            {
                if (ex == null)
                {
                    if (result.Length > 0)
                    {
                        result.Remove(result.Length - 1, 1);
                    }
                    return result.ToString();
                }
                result = result.Append(ex.Message).Append(",");
                ex = ex.InnerException;
            }
        }

    }
}
