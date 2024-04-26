using Forum.Application.Comments;
using Forum.Application.Topics;
using Forum.Application.Users;
using Forum.Domain.Comments;
using Forum.Domain.Topics;
using Forum.Domain.Users;
using Mapster;

namespace Forum.Api.Infrastructure.Mapping
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection services)
        {
            TypeAdapterConfig<UserRequestModel, User>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<UserRequestModel, UserResponseModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<TopicRequestModel, Topic>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<TopicRequestModel, TopicResponseModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<CommentRequestModel, Comment>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<CommentRequestModel, CommentResponseModel>
            .NewConfig()
            .TwoWays();
        }
    }
}
