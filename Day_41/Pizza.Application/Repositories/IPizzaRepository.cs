using Pizza.Domain.Entity;

namespace Pizza.Application.Repositories
{
    public interface IPizzaRepository
    {
        Task<List<PizzaEntity>> GetAll(CancellationToken cancellationToken);
        Task<PizzaEntity> Get(CancellationToken cancellationToken, int id);
        Task Create(CancellationToken cancellationToken, PizzaEntity pizza);
        Task Update(CancellationToken cancellationToken, PizzaEntity pizza);
        Task Delete(CancellationToken cancellationToken, int id);
        Task<bool> Exists(CancellationToken cancellationToken, int id);
    }
}