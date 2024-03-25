using ToDo.Application.BaseEntities;

namespace ToDo.Application.Users
{
    public class User : BaseEntity
    {

        public string Username { get; set; }

        public string Password { get; set; }

    }
}