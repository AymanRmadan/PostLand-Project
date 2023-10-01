using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;

namespace PostLand.Application.Features.Categories.Commands.DeleteCateory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, string>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<string> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var catrgory = await _categoryRepository.GetByIdAsync(request.Id);
            if (catrgory == null)
            {
                return "Category Not Found";
            }
            await _categoryRepository.DeleteAsync(catrgory);
            return "Delete Operation is Done";
        }
    }
}
