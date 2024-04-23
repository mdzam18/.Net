using Forum.Application.Topics;
using Forum.Domain.Topics;
using Forum.Persistence.Context;
using ToDo.Infrastructure;

namespace Forum.Infrastructure.Topics
{
    public class TopicRepository : BaseRepository<Topic>, ITopicRepository
    {

        public TopicRepository(ForumContext context) : base(context)
        {

        }

        public async Task<Topic> GetAsync(CancellationToken cancellationToken, int id)
        {
            return await base.GetAsync(cancellationToken, id);
        }

        public async Task<List<Topic>> GetAllasync(CancellationToken cancellationToken)
        {
            return await base.GetAllAsync(cancellationToken);
        }

        public async Task CreateAsync(CancellationToken cancellationToken, Topic topic)
        {
            await base.AddAsync(cancellationToken, topic);
        }

        public async Task UpdateAsync(CancellationToken cancellationToken, Topic topic)
        {
            await base.UpdateAsync(cancellationToken, topic);
        }

        public async Task DeleteAsync(CancellationToken cancellationToken, int id)
        {
            await base.RemoveAsync(cancellationToken, id);
        }

        public async Task<bool> Exists(CancellationToken cancellationToken, int id)
        {
            return await base.AnyAsync(cancellationToken, x => x.Id == id);
        }
    }
}
