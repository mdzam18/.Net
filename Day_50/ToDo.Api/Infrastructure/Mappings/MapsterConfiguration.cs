using Mapster;
using ToDo.Api.Model.DTO;
using ToDo.Application.Users;

namespace ToDo.Api.Infrastructure.Mappings
{
    public static class MapsterConfiguration
    {

        public static void RegisterMaps(this IServiceCollection services)
        {
            TypeAdapterConfig<UserResponseModel, UserDTO>
             .NewConfig()
             .TwoWays();

            TypeAdapterConfig<UserRequestModel, User>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<UserRequestModel, UserResponseModel>
            .NewConfig()
            .TwoWays();
        }

    }
}
