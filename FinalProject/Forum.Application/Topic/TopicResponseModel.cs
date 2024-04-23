using Forum.Application.Comments;
using Forum.Application.Users;

namespace Forum.Application.Topics
{
    public class TopicResponseModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        //Navigation Property
        public UserResponseModel User { get; set; }

        public List<CommentResponseModel> Comments { get; set; }
    }
}
