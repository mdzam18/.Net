using Forum.Domain.Users;

namespace Forum.Api.Model.DTO
{
    public class TopicDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        //Navigation Property
        public UserDTO UserDTO { get; set; }

        public int UserId { get; set; }


        public List<CommentDTO> Comments { get; set; }

    }
}
