using Forum.Domain.Comments;
using Forum.Domain.Users;

namespace Forum.Domain.Topics
{
    public class Topic
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public List<Comment> Comments { get; set; } 

        //Navigation Property
        public User User { get; set; }

    }
}
