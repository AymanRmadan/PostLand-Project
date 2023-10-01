using MediatR;

namespace PostLand.Application.Features.Categories.Commands.DeleteCateory
{
    public class DeleteCategoryCommand : IRequest<string>
    {
        public int Id { get; set; }
        public DeleteCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
