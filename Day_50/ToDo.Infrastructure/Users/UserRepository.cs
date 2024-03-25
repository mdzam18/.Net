using ToDo.Application.Repositories;
using ToDo.Application.Users;
using ToDo.Persistence.Context;

namespace ToDo.Infrastructure.Users
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        const string SECRET_KEY = "2342342asdasdad";

        private readonly string _connection;

        public UserRepository(ToDoContext context) : base(context)
        {
        }

        public async Task CreateAsync(CancellationToken cancellationToken, User user)
        {
            await base.AddAsync(cancellationToken, user);
        }

        public Task<bool> Exists(CancellationToken cancellationToken, string username)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(CancellationToken cancellationToken, string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
