namespace Forum.Application.Comments
{
    public interface ICommentService
    {
        Task<List<CommentResponseModel>> GetAll(CancellationToken cancellationToken);
        Task<List<CommentResponseModel>> GetAllByUserId(CancellationToken cancellationToken, int userId);
        Task<List<CommentResponseModel>> GetAllByTopicId(CancellationToken cancellationToken, int topicId);
        Task<CommentResponseModel> Get(CancellationToken cancellationToken, int id);
        Task Create(CancellationToken cancellationToken, CommentRequestModel comment);
        Task Update(CancellationToken cancellationToken, CommentRequestModel comment);
        Task Delete(CancellationToken cancellationToken, int id);
    }
}
