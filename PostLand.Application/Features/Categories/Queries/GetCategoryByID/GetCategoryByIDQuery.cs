using MediatR;

namespace PostLand.Application.Features.Categories.Queries.GetCategoryByID
{
    public class GetCategoryByIDQuery : IRequest<GetCategoryByIDViewModel>
    {
        public int Id { get; set; }
        public GetCategoryByIDQuery(int id)
        {
            Id = id;
        }
    }
}
