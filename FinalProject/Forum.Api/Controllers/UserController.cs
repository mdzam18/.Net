using Forum.Api.Infrastructure.Auth.JWT;
using Forum.Application.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Forum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IOptions<JWTConfiguration> _options;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<UserResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            return await _userService.GetAll(cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<UserResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            return await _userService.Get(cancellationToken, id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            await _userService.Delete(cancellationToken, id);
        }

        [HttpPost]
        public async Task Post(CancellationToken cancellationToken, UserCreateModel request)
        {
            await _userService.CreateAsync(cancellationToken, request);
        }

        [HttpPut]
        public async Task Put(CancellationToken cancellationToken, UserRequestModel request)
        {
            await _userService.Update(cancellationToken, request);
        }

        [Route("login")]
        [HttpPost]
        public async Task<string> LogIn(UserLoginModel user, CancellationToken cancellation = default)
        {
            var result = await _userService.AuthenticationAsync(cancellation, user.Email, user.Password);

            return JWTHelper.GenerateSecurityToken(result, _options);
        }

    }
}
