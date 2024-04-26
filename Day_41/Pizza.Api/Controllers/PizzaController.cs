using Microsoft.AspNetCore.Mvc;
using Pizza.Application.Pizzas;

namespace Pizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<List<PizzaResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            return await _pizzaService.GetAll(cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<PizzaResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            return await _pizzaService.Get(cancellationToken, id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            await _pizzaService.Delete(cancellationToken, id);
        }

        [HttpPost]
        public async Task Post(CancellationToken cancellationToken, PizzaRequestModel request)
        {
            await _pizzaService.Create(cancellationToken, request);
        }

        [HttpPut]
        public async Task Put(CancellationToken cancellationToken, PizzaRequestModel request)
        {
            await _pizzaService.Update(cancellationToken, request);
        }

    }
}