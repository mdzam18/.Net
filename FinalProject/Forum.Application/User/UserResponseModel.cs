using Forum.Application.Comments;
using Forum.Application.Topics;

namespace Forum.Application.Users
{
    public class UserResponseModel
    {
        public string Username { get; set; }

        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Gender { get; set; }

        public List<TopicResponseModel> Topics { get; set; }

        public List<CommentResponseModel> Comments { get; set; }
    }
}
