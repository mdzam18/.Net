namespace Forum.Application.Comments
{
    public class CommentRequestModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public int TopicId { get; set; }
    }
}
