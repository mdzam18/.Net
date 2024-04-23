using Forum.Application.Exceptions;
using Forum.Domain.Users;
using Mapster;
using System.Threading;

namespace Forum.Application.Users
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> AuthenticationAsync(CancellationToken cancellationToken, string email, string password)
        {
            var result = await _repository.GetAsync(cancellationToken, email, password);

            if (result == null)
                throw new IncorrectEmailOrPasswordException("email or password is incorrect");

            return result.Username;
        }

        public async Task CreateAsync(CancellationToken cancellationToken, UserCreateModel user)
        {
            var userToInsert = user.Adapt<User>();

            await _repository.CreateAsync(cancellationToken, userToInsert);
        }

        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            if (!await _repository.Exists(cancellationToken, id))
                throw new UserNotFoundException(id.ToString());

            await _repository.DeleteAsync(cancellationToken, id);
        }

        public async Task<UserResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            var result = await _repository.GetAsync(cancellationToken, id);

            if (result == null)
                throw new UserNotFoundException(id.ToString());
            else
                return result.Adapt<UserResponseModel>();
        }

        public async Task<List<UserResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(cancellationToken);

            return result.Adapt<List<UserResponseModel>>();
        }

        public async Task Update(CancellationToken cancellationToken, UserRequestModel user)
        {
            if (!await _repository.Exists(cancellationToken, user.Id))
                throw new UserNotFoundException(user.Id.ToString());

            var userToUpdate = user.Adapt<User>();

            await _repository.UpdateAsync(cancellationToken, userToUpdate);
        }
    }
}