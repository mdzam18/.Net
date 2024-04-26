namespace Forum.Application.Exceptions
{
    public class CommentNotFoundException : Exception
    {
        public string Code = "CommentNotFound";

        public CommentNotFoundException(string message) : base(message) { }

    }
}
