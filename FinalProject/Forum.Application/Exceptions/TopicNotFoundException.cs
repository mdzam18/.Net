namespace Forum.Application.Exceptions
{
    public class TopicNotFoundException : Exception
    {

        public string Code = "TopicNotFound";

        public TopicNotFoundException(string message) : base(message) { }

    }
}
