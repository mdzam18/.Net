using Forum.Application.Exceptions;
using Forum.Application.Topics;
using Forum.Domain.Comments;
using Forum.Domain.Topics;
using Mapster;

namespace Forum.Application.Comments
{
    public class CommentService : ICommentService
    {

        private readonly ICommentRepository _repository;

        public CommentService(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task Create(CancellationToken cancellationToken, CommentRequestModel comment)
        {
            var commentToInsert = comment.Adapt<Comment>();

            await _repository.CreateAsync(cancellationToken, commentToInsert);
        }

        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            if (!await _repository.Exists(cancellationToken, id))
                throw new CommentNotFoundException(id.ToString());

            await _repository.DeleteAsync(cancellationToken, id);
        }

        public async Task<CommentResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            var result = await _repository.GetAsync(cancellationToken, id);

            if (result == null)
                throw new CommentNotFoundException(id.ToString());
            else
                return result.Adapt<CommentResponseModel>();
        }

        public async Task<List<CommentResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(cancellationToken);

            return result.Adapt<List<CommentResponseModel>>();
        }

        public async Task Update(CancellationToken cancellationToken, CommentRequestModel comment)
        {
            //if (!await _repository.Exists(cancellationToken, comment.Id))
            //    throw new TopicNotFoundException(comment.Id.ToString());

            //var commentToUpdate = comment.Adapt<Comment>();

            //await _repository.UpdateAsync(cancellationToken, commentToUpdate);
        }
    }
}
