namespace Delegates
{
    class ChainedValidation
    {

        List<string> _PropertiesOrder;

        public ChainedValidation()
        {
            _PropertiesOrder = new List<string>();
        }

        public List<string> GetInvalidValues(Book book)
        {
            Predicate<Book> ValidatorDelegate = (book) => CheckTitle(book);
            ValidatorDelegate += (book) => CheckAuthor(book);
            ValidatorDelegate += (book) => CheckISBN(book);
            ValidatorDelegate += (book) => CheckPublisherValidation(book);
            ValidatorDelegate += (book) => CheckPublicationDateValidation(book);
            ValidatorDelegate += (book) => CheckNumberOfPages(book);
            ValidatorDelegate += (book) => CheckPrice(book);
            ValidatorDelegate += (book) => CheckIsAvailable(book);
            ValidatorDelegate += (book) => CheckGenre(book);

            ValidatorDelegate.Invoke(book);
            return _PropertiesOrder;
        }

        private bool CheckISBN(Book book)
        {
            string isbn = book.ISBN;
            if (isbn != null)
            {
                if (isbn.Count() == 13 && ContainsOnlyDigits(isbn))
                {
                    return true;
                }
            }
            _PropertiesOrder.Add("ISBN");
            return false;
        }

        private bool CheckTitle(Book book)
        {
            string title = book.Title;
            if (title != null)
            {
                if (title.Count() > 1 && title.Count() < 255 && ContainsOnlyLetters(title))
                {
                    return true;
                }
            }
            _PropertiesOrder.Add("Title");
            return false;
        }

        private bool CheckAuthor(Book book)
        {
            string author = book.Author;
            if (author != null)
            {
                if (author.Count() > 3 && author.Count() < 128 && ContainsOnlyLetters(author))
                {
                    return true;
                }
            }
            _PropertiesOrder.Add("Author");
            return false;
        }

        private bool ContainsOnlyDigits(string iSBN)
        {
            foreach (char c in iSBN)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ContainsOnlyLetters(string title)
        {
            foreach (char c in title)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckPublisherValidation(Book book)
        {
            if (book.Publisher != null)
            {
                int count = book.Publisher.Count();
                if (count > 2 && count < 64)
                {
                    return true;
                }
            }
            _PropertiesOrder.Add("Publisher");
            return false;
        }

        private bool CheckPublicationDateValidation(Book book)
        {
            DateTime? date = book.PublicationDate;
            if (date == null)
            {
                return true;
            }
            if (date < DateTime.Now)
            {
                return true;
            }
            _PropertiesOrder.Add("Publication Date");
            return false;
        }

        private bool CheckGenre(Book book)
        {
            Genre? genre = book.Genre;
            if (book.Genre != null)
            {
                return true;
            }
            _PropertiesOrder.Add("Genre");
            return false;
        }

        private bool CheckNumberOfPages(Book book)
        {
            if (book.NumberOfPages != null)
            {
                if (book.NumberOfPages > 0)
                {
                    return true;
                }
            }
            _PropertiesOrder.Add("Number of pages");
            return false;
        }

        private bool CheckIsAvailable(Book book)
        {
            if (book.IsAvailable == null)
            {
                _PropertiesOrder.Add("Is available");
                return false;
            }
            return true;
        }

        private bool CheckPrice(Book book)
        {
            if (book.Price != null)
            {
                if (book.Price > 0)
                {
                    return true;
                }
                _PropertiesOrder.Add("Price");
                return false;
            }
            return true;
        }

    }
}