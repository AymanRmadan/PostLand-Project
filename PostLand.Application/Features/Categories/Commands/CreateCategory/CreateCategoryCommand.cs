using MediatR;

namespace PostLand.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<string>
    {
        public string Name { get; set; }
    }
}
