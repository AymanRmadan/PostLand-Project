using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;

namespace PostLand.Application.Features.Categories.Queries.GetCategoryByID
{
    public class GetCategoryByIDHandler : IRequestHandler<GetCategoryByIDQuery, GetCategoryByIDViewModel>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryByIDHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<GetCategoryByIDViewModel> Handle(GetCategoryByIDQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);
            if (category == null)
            {
                return null;
            }
            return _mapper.Map<GetCategoryByIDViewModel>(category);

        }
    }
}
