namespace Delegates
{
    class Book
    {

        public Book(string title, string author, string isbn, string publisher, DateTime? publicationDate, int? numberOfPages, bool? isAvailable, decimal? price, Genre? genre)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Publisher = publisher;
            PublicationDate = publicationDate;
            NumberOfPages = numberOfPages;
            IsAvailable = isAvailable;
            Price = price;
            Genre = genre;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public string Publisher { get; set; }

        public DateTime? PublicationDate { get; set; }

        public Genre? Genre { get; set; }

        public int? NumberOfPages { get; set; }

        public bool? IsAvailable { get; set; }

        public decimal? Price { get; set; }

    }
}