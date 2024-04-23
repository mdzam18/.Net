namespace Forum.Application.Comments
{
    public interface ICommentService
    {
        Task<List<CommentResponseModel>> GetAll(CancellationToken cancellationToken);
        Task<CommentResponseModel> Get(CancellationToken cancellationToken, int id);
        Task Create(CancellationToken cancellationToken, CommentRequestModel comment);
        Task Update(CancellationToken cancellationToken, CommentRequestModel comment);
        Task Delete(CancellationToken cancellationToken, int id);
    }
}
