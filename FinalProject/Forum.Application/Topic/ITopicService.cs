namespace Forum.Application.Topics
{
    public interface ITopicService
    {
        Task<List<TopicResponseModel>> GetAll(CancellationToken cancellationToken);
        Task<TopicResponseModel> Get(CancellationToken cancellationToken, int id);
        Task Create(CancellationToken cancellationToken, TopicRequestModel topic);
        Task Update(CancellationToken cancellationToken, TopicRequestModel topic);
        Task Delete(CancellationToken cancellationToken, int id);

    }
}
