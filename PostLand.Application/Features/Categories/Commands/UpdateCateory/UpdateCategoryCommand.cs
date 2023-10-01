using MediatR;

namespace PostLand.Application.Features.Categories.Commands.UpdateCateory
{
    public class UpdateCategoryCommand : IRequest<string>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
