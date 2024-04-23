namespace Forum.Api.Model.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Gender { get; set; }

        //Navigation properties
        public List<TopicDTO> Topics { get; set; }

        public List<CommentDTO> Comments { get; set; }
    }
}