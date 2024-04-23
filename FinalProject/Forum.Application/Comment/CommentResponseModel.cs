using Forum.Application.Topics;
using Forum.Application.Users;

namespace Forum.Application.Comments
{
    public class CommentResponseModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        //Navigation Properties
        public UserResponseModel User { get; set; }

        public int UserId { get; set; }

        public TopicResponseModel Topic { get; set; }

        public int TopicId { get; set; }

    }
}
