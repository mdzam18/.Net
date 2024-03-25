using ToDo.Application.Users;

namespace ToDo.Application.Services
{
    public interface IUserService
    {
        Task<string> AuthenticationAsync(CancellationToken cancellation, string username, string password);
        Task CreateAsync(CancellationToken cancellation, UserCreateModel user);
    }
}
