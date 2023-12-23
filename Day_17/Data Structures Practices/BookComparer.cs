namespace Data_Structures_Practices
{
    public class BookComparerByAuthorName : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book? x, Book? y)
        {
            return x.AuthorFullName.CompareTo(y.AuthorFullName);
        }
    }

    public class BookComparerByBookName : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book? x, Book? y)
        {
            return x.BookName.CompareTo(y.BookName);
        }
    }

    public class BookComparerByISBN : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book? x, Book? y)
        {
            return x.ISBN.CompareTo(y.ISBN);
        }
    }

    public class BookComparerByReleaseYear : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book? x, Book? y)
        {
            return x.ReleaseYear - y.ReleaseYear;
        }
    }

    public class BookComparerByGenre : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book? x, Book? y)
        {
            return x.GenreType.ToString().CompareTo(y.GenreType.ToString());
        }
    }

}
