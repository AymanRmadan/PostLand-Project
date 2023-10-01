using MediatR;

namespace PostLand.Application.Features.Categories.Queries.GetAllCategory
{
    public class GetListCategoryQuery : IRequest<List<GetListCategoryViewModel>>
    {
    }
}
