namespace ToDo.Api.Model.DTO
{
    public class UserDTO : BaseEntityDTO
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
