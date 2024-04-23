using Forum.Application.Exceptions;
using Forum.Domain.Topics;
using Mapster;

namespace Forum.Application.Topics
{
    public class TopicService : ITopicService
    {

        private readonly ITopicRepository _repository;

        public TopicService(ITopicRepository repository)
        {
            _repository = repository;
        }

        public async Task Create(CancellationToken cancellationToken, TopicRequestModel topic)
        {
            var topicToInsert = topic.Adapt<Topic>();

            await _repository.CreateAsync(cancellationToken, topicToInsert);
        }

        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            if (!await _repository.Exists(cancellationToken, id))
                throw new TopicNotFoundException(id.ToString());

            await _repository.DeleteAsync(cancellationToken, id);
        }

        public async Task<TopicResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            var result = await _repository.GetAsync(cancellationToken, id);

            if (result == null)
                throw new TopicNotFoundException(id.ToString());
            else
                return result.Adapt<TopicResponseModel>();
        }

        public async Task<List<TopicResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(cancellationToken);

            return result.Adapt<List<TopicResponseModel>>();
        }

        public async Task Update(CancellationToken cancellationToken, TopicRequestModel topic)
        {
            if (!await _repository.Exists(cancellationToken, topic.UserId))
                throw new TopicNotFoundException(topic.UserId.ToString());

            var topicToUpdate = topic.Adapt<Topic>();

            await _repository.UpdateAsync(cancellationToken, topicToUpdate);
        }
    }
}
