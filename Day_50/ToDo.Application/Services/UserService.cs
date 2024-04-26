using Mapster;
using ToDo.Application.Repositories;
using ToDo.Application.Users;

namespace ToDo.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> AuthenticationAsync(CancellationToken cancellationToken, string username, string password)
        {
            var result = await _repository.GetAsync(cancellationToken, username, password);

            if (result == null)
                throw new Exception("username or password is incorrect");

            return result.Username;
        }

        public async Task CreateAsync(CancellationToken cancellationToken, UserCreateModel userModel)
        {
            var exists = await _repository.Exists(cancellationToken, userModel.Username);

            if (exists)
                throw new Exception("user already exists");

            var user = userModel.Adapt<User>();
            //user.Password = GenerateHash(user.Password);
            await _repository.CreateAsync(cancellationToken, user);
        }
    }
}