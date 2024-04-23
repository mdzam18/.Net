using Forum.Application.Comments;
using Forum.Domain.Comments;
using Forum.Persistence.Context;
using ToDo.Infrastructure;

namespace Forum.Infrastructure.Comments
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {

        public CommentRepository(ForumContext context) : base(context)
        {

        }

        public async Task<Comment> GetAsync(CancellationToken cancellationToken, int id)
        {
            return await base.GetAsync(cancellationToken, id);
        }

        public async Task<List<Comment>> GetAllasync(CancellationToken cancellationToken)
        {
            return await base.GetAllAsync(cancellationToken);
        }

        public async Task CreateAsync(CancellationToken cancellationToken, Comment comment)
        {
            await base.AddAsync(cancellationToken, comment);
        }

        public async Task UpdateAsync(CancellationToken cancellationToken, Comment comment)
        {
            await base.UpdateAsync(cancellationToken, comment);
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