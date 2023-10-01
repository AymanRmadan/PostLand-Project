using MediatR;
using PostLand.Application.Contracts.Persistence;

namespace PostLand.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, string>
    {
        private readonly IPostRepository _postRepository;
        public DeletePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<string> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetByIdAsync(request.PostId);
            if (post == null)
            {
                return "Post Not Found";
            }

            await _postRepository.DeleteAsync(post);

            return "Delete Operation is Done";
        }
    }

}
