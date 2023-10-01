using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using PostLand.Domain.Entities;

namespace PostLand.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, string>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<string> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            CreateCategoryCommandVlidation validation = new CreateCategoryCommandVlidation();
            var result = await validation.ValidateAsync(request);
            if (result.Errors.Any())
            {
                throw new Exception("category is not valid");
            }
            await _categoryRepository.AddAsync(category);
            return "Create Operation is Done";
        }
    }
}
