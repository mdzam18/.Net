namespace Data_Structures_Practices
{

    enum Genre
    {
        Documentary,
        Fantasy,
        Fiction,
        Action
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ShowBracketsBalancedMethod();
            Console.WriteLine();
            ShowPointCalculateMethod();
            Console.WriteLine();
            ShowMultipleReturnValues();
            Console.WriteLine();
            ShowSortBooksMethod();
        }

        private static void ShowSortBooksMethod()
        {
            Console.WriteLine("Sort by release year");
            List<Book> books = new List<Book>();
            Book LordOfTheRings = new Book("Tolkin", "Lord of the rings", 1950, "0-23-023", Genre.Fantasy);
            books.Add(LordOfTheRings);
            Book HarryPotter = new Book("Rowling", "Harry Potter", 1990, "0-12-32", Genre.Action);
            books.Add(HarryPotter);
            books.Sort(new BookComparerByReleaseYear());
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\nSort by book name");
            books.Sort(new BookComparerByBookName());
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\nSort by author name");
            books.Sort(new BookComparerByAuthorName());
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\nSort by ISBN name");
            books.Sort(new BookComparerByISBN());
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\nSort by genre");
            books.Sort(new BookComparerByGenre());
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        private static void ShowMultipleReturnValues()
        {
            Console.WriteLine("Min value function");
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine());
            Tuple<double, string> result = MyMath.Min(second, first);
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);
        }

        private static void ShowPointCalculateMethod()
        {
            Console.Write("Enter first point x: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter first point y: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second point x: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter second point y: ");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: {0}", PointCalculator.GetDistance(new Tuple<int, int>(x1, y1), new Tuple<int, int>(x2, y2)));
        }

        private static void ShowBracketsBalancedMethod()
        {
            Console.Write("Enter Brackets Combination: ");
            string str = Console.ReadLine();
            if (BracketsBalance.IsBracketsBalanced(str))
            {
                Console.WriteLine("Brackets are balanced");
            }
            else
            {
                Console.WriteLine("Brackets are not balanced");
            }
        }

    }
}
