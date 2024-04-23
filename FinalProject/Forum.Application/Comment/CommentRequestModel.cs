using Forum.Application.Topics;
using Forum.Application.Users;

namespace Forum.Application.Comments
{
    public class CommentRequestModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        //Navigation Properties
     //   public UserRequestModel User { get; set; }

        public int UserId { get; set; }

     //   public TopicRequestModel Topic { get; set; }

        public int TopicId { get; set; }
    }
}
