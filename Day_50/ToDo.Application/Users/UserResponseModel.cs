using ToDo.Application.BaseEntities;

namespace ToDo.Application.Users
{
    public class UserResponseModel : BaseEntity
    {

        public string Username { get; set; }

        public string PasswordHash { get; set; }

    }
}
