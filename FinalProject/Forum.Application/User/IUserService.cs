namespace Forum.Application.Users
{
    public interface IUserService
    {

        Task<string> AuthenticationAsync(CancellationToken cancellationToken, string email, string password);
        Task CreateAsync(CancellationToken cancellationToken, UserCreateModel user);
        Task<List<UserResponseModel>> GetAll(CancellationToken cancellationToken);
        Task<UserResponseModel> Get(CancellationToken cancellationToken, int id);
        Task Update(CancellationToken cancellationToken, UserRequestModel user);
        Task Delete(CancellationToken cancellationToken, int id);

    }
}