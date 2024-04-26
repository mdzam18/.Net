namespace Forum.Application.Comments
{
    public class CommentResponseModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public int TopicId { get; set; }
    }
}
