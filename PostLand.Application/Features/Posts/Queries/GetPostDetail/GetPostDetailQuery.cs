using MediatR;

namespace PostLand.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQuery : IRequest<GetPostDetailViewModel>
    {
        public int PostId { get; set; }
    }
}
