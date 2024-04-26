using Forum.Application.Users;
using Forum.Domain.Users;
using Forum.Persistence.Context;
using System.Linq.Expressions;

namespace Forum.Infrastructure.Users
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        public UserRepository(ForumContext context) : base(context)
        {

        }

        public async Task<User> GetAsync(CancellationToken cancellationToken, int id)
        {
            return await base.GetAsync(cancellationToken, id);
        }

        public async Task<List<User>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await base.GetAllAsync(cancellationToken);
        }

        public async Task<List<User>> GetAllAsync(CancellationToken cancellation, Expression<Func<User, bool>> func)
        {
            return await base.GetAllAsync(cancellation, func);
        }

        public async Task CreateAsync(CancellationToken cancellationToken, User user)
        {
            await base.AddAsync(cancellationToken, user);
        }

        public async Task UpdateAsync(CancellationToken cancellationToken, User user)
        {
            await base.UpdateAsync(cancellationToken, user);
        }

        public async Task DeleteAsync(CancellationToken cancellationToken, int id)
        {
            await base.RemoveAsync(cancellationToken, id);
        }

        public async Task<bool> Exists(CancellationToken cancellationToken, int id)
        {
            return await base.AnyAsync(cancellationToken, x => x.Id == id);
        }

        public async Task<User> GetAsync(CancellationToken cancellationToken, string email)
        {
            return await base.GetAsync(cancellationToken, _ => _.Email.Equals(email));
        }
    }
}