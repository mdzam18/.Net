using Forum.Domain.Topics;

namespace Forum.Application.Topics
{
    public interface ITopicRepository
    {
        Task<List<Topic>> GetAllAsync(CancellationToken cancellationToken);
        Task<Topic> GetAsync(CancellationToken cancellationToken, int id);
        Task CreateAsync(CancellationToken cancellationToken, Topic topic);
        Task UpdateAsync(CancellationToken cancellationToken, Topic topic);
        Task DeleteAsync(CancellationToken cancellationToken, int id);
        Task<bool> Exists(CancellationToken cancellationToken, int id);
    }
}
