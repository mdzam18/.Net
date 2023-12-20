namespace Data_Structures_Practices
{
    internal class Book
    {

        public Book(string authorFullName, string bookName, int releaseYear, string iSBN, Genre genre)
        {
            AuthorFullName = authorFullName;
            BookName = bookName;
            ReleaseYear = releaseYear;
            ISBN = iSBN;
            GenreType = genre;
        }

        public string AuthorFullName { get; set; }

        public string BookName { get; set; }

        public int ReleaseYear { get; set; }

        public string ISBN { get; set; }

        public Genre GenreType { get; set; }

        public override string ToString()
        {
            return AuthorFullName + " " + BookName + " " + ReleaseYear + " " + ISBN + " " + GenreType;
        }

    }
}
