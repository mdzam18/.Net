using Microsoft.EntityFrameworkCore;
using Pizza.Domain.Entity;

namespace Pizza.Application.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public PizzaRepository(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(CancellationToken cancellationToken, PizzaEntity pizza)
        {
            await _dbContext.Pizzas.AddAsync(pizza);
            _dbContext.SaveChanges();
        }

        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            var pizzaToDelete = await _dbContext.Pizzas.FindAsync(id);

            if (pizzaToDelete != null)
            {
                _dbContext.Pizzas.Remove(pizzaToDelete);
                await _dbContext.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task<bool> Exists(CancellationToken cancellationToken, int id)
        {
            var pizza = await _dbContext.Pizzas.FindAsync(id);
            if (pizza != null)
            {
                return true;
            }
            return false;
        }

        public async Task<PizzaEntity> Get(CancellationToken cancellationToken, int id)
        {
            return await _dbContext.Pizzas.SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<List<PizzaEntity>> GetAll(CancellationToken cancellationToken)
        {
            return await _dbContext.Pizzas.ToListAsync(cancellationToken);
        }

        public async Task Update(CancellationToken cancellationToken, PizzaEntity pizza)
        {
            var existingPizza = await _dbContext.Pizzas.FindAsync(pizza.Id);
            if (existingPizza != null)
            {
                Delete(cancellationToken, existingPizza.Id);
                Create(cancellationToken, pizza);
            }
        }

    }
}