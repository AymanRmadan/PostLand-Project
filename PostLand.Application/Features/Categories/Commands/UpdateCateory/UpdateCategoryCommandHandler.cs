using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using PostLand.Domain.Entities;

namespace PostLand.Application.Features.Categories.Commands.UpdateCateory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, string>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<string> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);
            if (category == null)
            {
                return "Category Not Found";
            }
            var categoryMap = _mapper.Map<Category>(request);
            await _categoryRepository.UpdateAsync(categoryMap);
            return "Update Operation is Done";

        }
    }
}
