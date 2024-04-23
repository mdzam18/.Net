using Forum.Application.Topics;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicService _topicService;

        public TopicController(ITopicService topicService)
        {
            _topicService = topicService;
        }

        [HttpGet]
        public async Task<List<TopicResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            return await _topicService.GetAll(cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<TopicResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            return await _topicService.Get(cancellationToken, id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            await _topicService.Delete(cancellationToken, id);
        }

        [HttpPost]
        public async Task Post(CancellationToken cancellationToken, TopicRequestModel request)
        {
            await _topicService.Create(cancellationToken, request);
        }

        [HttpPut]
        public async Task Put(CancellationToken cancellationToken, TopicRequestModel request)
        {
            await _topicService.Update(cancellationToken, request);
        }
    }
}
