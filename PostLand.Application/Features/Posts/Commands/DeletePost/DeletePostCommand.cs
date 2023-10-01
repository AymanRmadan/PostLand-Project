using MediatR;

namespace PostLand.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest<string>
    {
        public int PostId { get; set; }
    }

}
