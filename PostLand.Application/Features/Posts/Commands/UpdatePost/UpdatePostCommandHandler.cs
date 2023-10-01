using AutoMapper;
using MediatR;
using PostLand.Application.Contracts.Persistence;
using PostLand.Domain.Entities;

namespace PostLand.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, string>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;
        public UpdatePostCommandHandler(IAsyncRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetByIdAsync(request.Id);

            if (post == null)
            {
                return "Post Not Found";
            }
            Post postMap = _mapper.Map<Post>(request);

            await _postRepository.UpdateAsync(postMap);

            return "Update Operation is Done";
        }
    }
}
