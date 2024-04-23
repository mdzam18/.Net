using Forum.Domain.Users;

namespace Forum.Application.Users
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync(CancellationToken cancellationToken);
        Task<User> GetAsync(CancellationToken cancellationToken, int id);
        Task CreateAsync(CancellationToken cancellationToken, User user);
        Task UpdateAsync(CancellationToken cancellationToken, User user);
        Task DeleteAsync(CancellationToken cancellationToken, int id);
        Task<bool> Exists(CancellationToken cancellationToken, int id);
        Task<User> GetAsync(CancellationToken cancellationToken, string email, string password);
    }
}