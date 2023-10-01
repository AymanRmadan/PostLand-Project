using FluentValidation;

namespace PostLand.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandVlidation : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandVlidation()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
        }
    }
}
