using Forum.Application.Comments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<List<CommentResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            return await _commentService.GetAll(cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<CommentResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            return await _commentService.Get(cancellationToken, id);
        }

        [HttpGet("User/{userId}")]
        public async Task<List<CommentResponseModel>> GetByUserId(CancellationToken cancellationToken, int userId)
        {
            return await _commentService.GetAllByUserId(cancellationToken, userId);
        }

        [HttpGet("Topic/{topicId}")]
        public async Task<List<CommentResponseModel>> GetByTopicId(CancellationToken cancellationToken, int topicId)
        {
            return await _commentService.GetAllByTopicId(cancellationToken, topicId);
        }

        [HttpDelete("{id}")]
        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            await _commentService.Delete(cancellationToken, id);
        }

        [HttpPost]
        public async Task Post(CancellationToken cancellationToken, CommentRequestModel request)
        {
            await _commentService.Create(cancellationToken, request);
        }

        [HttpPut]
        public async Task Put(CancellationToken cancellationToken, CommentRequestModel request)
        {
            await _commentService.Update(cancellationToken, request);
        }
    }
}