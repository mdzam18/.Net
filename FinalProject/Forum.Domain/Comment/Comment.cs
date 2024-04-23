using Forum.Domain.Topics;
using Forum.Domain.Users;

namespace Forum.Domain.Comments
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        //Navigation Properties
        public User User { get; set; }

        public int UserId { get; set; }

        public Topic Topic { get; set; }

        public int TopicId { get; set; }

    }
}