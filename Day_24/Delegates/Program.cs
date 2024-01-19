namespace Delegates
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ConsolidatedLogging.LogMessage(".Net");
            SequantialCalculations.MakeSequantialCalculations(2, 4);
            ShowChainedValidation();
            ShowDataPipeline();
        }

        private static void ShowDataPipeline()
        {
            List<Book> books = new List<Book>();
            Book book = new Book("lord of the rings", "Tolkin", "121212312312", "a", null, 0, false, 20, Genre.Fiction);
            books.Add(book);
            book = new Book("Harry Potter", "Rowling", "1221212312312", "ab", null, 0, false, 10, Genre.Fiction);
            books.Add(book);

            DataPipeline<Book> dataPipeline = new DataPipeline<Book>(b => b.Price > 11, b=> new BookDto(b.Title, b.Author, b.Genre.Value, b.IsAvailable.Value, b.Price.Value));
            var result = dataPipeline.Process(books);
            foreach (var item in result)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.Title, item.Author, item.Genre, item.IsAvailable, item.Price);
            }
        }

        private static void ShowChainedValidation()
        {
            ChainedValidation validation = new ChainedValidation();
            Book book = new Book("lordoftherings", "Tolkin", "121212312312", "a", null, 0, false, 10, Genre.Fiction);
            List<string> invalidValues = validation.GetInvalidValues(book);
            for (int i = 0; i < invalidValues.Count(); i++)
            {
                if (i == invalidValues.Count - 1)
                {
                    Console.Write("{0}", invalidValues[i]);
                }
                else
                {
                    Console.Write("{0}, ", invalidValues[i]);
                }
            }
            Console.WriteLine();
        }
    }
}