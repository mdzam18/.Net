using Pizza.Application.Exceptions;
using Pizza.Application.Repositories;
using Mapster;
using Pizza.Domain.Entity;

namespace Pizza.Application.Pizzas
{

    public class PizzaService : IPizzaService
    {

        private readonly IPizzaRepository _repository;

        public PizzaService(IPizzaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PizzaResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repository.GetAll(cancellationToken);

            return result.Adapt<List<PizzaResponseModel>>();
        }

        public async Task<PizzaResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            var result = await _repository.Get(cancellationToken, id);

            if (result == null)
                throw new PizzaNotFoundException(id.ToString());
            else
                return result.Adapt<PizzaResponseModel>();
        }

        public async Task Create(CancellationToken cancellationToken, PizzaRequestModel pizza)
        {
            var personToInsert = pizza.Adapt<PizzaEntity>();

            await _repository.Create(cancellationToken, personToInsert);
        }

        public async Task Update(CancellationToken cancellationToken, PizzaRequestModel pizza)
        {
            if (!await _repository.Exists(cancellationToken, pizza.Id))
                throw new PizzaNotFoundException(pizza.Id.ToString());

            var personToUpdate = pizza.Adapt<PizzaEntity>();

            await _repository.Update(cancellationToken, personToUpdate);
        }

        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            if (!await _repository.Exists(cancellationToken, id))
                throw new PizzaNotFoundException(id.ToString());

            await _repository.Delete(cancellationToken, id);
        }

    }
}