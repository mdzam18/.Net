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

        public DateTime CreateDate { get; set; }

        public User User { get; set; }

        public Status Status{ get; set; }

        public State State { get; set; }

    }
}