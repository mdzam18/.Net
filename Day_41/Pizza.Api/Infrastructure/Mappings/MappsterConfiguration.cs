using Mapster;
using Pizza.Api.Model.DTO;
using Pizza.Application.Pizzas;
using Pizza.Domain.Entity;

namespace Pizza.Api.Infrastructure.Mappings
{
    public static class MappsterConfiguration
    {

        public static void RegisterMaps(this IServiceCollection services)
        {
            TypeAdapterConfig<PizzaResponseModel, PizzaDTO>
             .NewConfig()
             .TwoWays();

            TypeAdapterConfig<PizzaRequestModel, PizzaEntity>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<PizzaRequestModel, PizzaResponseModel>
            .NewConfig()
            .TwoWays();
        }

    }
}
