using Forum.Application.Users;

namespace Forum.UserBanHandler
{
    public class Worker : BackgroundService
    {
        private readonly IUserService _userService;
        public Worker(IUserService userService)
        {
            _userService = userService;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await _userService.UnbanAllUsers(cancellationToken);
                await Task.Delay(60000, cancellationToken);
            }
        }
    }
}
