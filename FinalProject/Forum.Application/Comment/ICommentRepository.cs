using Forum.Domain.Comments;

namespace Forum.Application.Comments
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync(CancellationToken cancellationToken);
        Task<List<Comment>> GetAllByTopicIdAsync(CancellationToken cancellationToken, int topicId);
        Task<List<Comment>> GetAllByUserIdAsync(CancellationToken cancellationToken, int userId);
        Task<Comment> GetAsync(CancellationToken cancellationToken, int id);
        Task CreateAsync(CancellationToken cancellationToken, Comment comment);
        Task UpdateAsync(CancellationToken cancellationToken, Comment comment);
        Task DeleteAsync(CancellationToken cancellationToken, int id);
        Task<bool> Exists(CancellationToken cancellationToken, int id);
    }
}
