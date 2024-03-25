using ToDo.Application.BaseEntities;

namespace ToDo.Application.Users
{
    public class UserRequestModel : BaseEntity
    {

        public string Username { get; set; }

        public string PasswordHash { get; set; }

    }
}