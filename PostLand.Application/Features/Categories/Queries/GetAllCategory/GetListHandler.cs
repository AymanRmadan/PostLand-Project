using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;

namespace PostLand.Application.Features.Categories.Queries.GetAllCategory
{
    public class GetListHandler : IRequestHandler<GetListCategoryQuery, List<GetListCategoryViewModel>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetListHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<List<GetListCategoryViewModel>> Handle(GetListCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.ListAllAsync();
            var categoriesMap = _mapper.Map<List<GetListCategoryViewModel>>(categories);
            return categoriesMap.ToList();
        }
    }
}
