using Forum.Domain.Comments;
using Forum.Domain.Topics;

namespace Forum.Domain.Users
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Gender { get; set; }

        //Navigation properties
        public List<Topic> Topics { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
