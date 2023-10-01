using MediatR;
using Microsoft.AspNetCore.Mvc;
using PostLand.Application.Features.Categories.Commands.CreateCategory;
using PostLand.Application.Features.Categories.Commands.DeleteCateory;
using PostLand.Application.Features.Categories.Commands.UpdateCateory;
using PostLand.Application.Features.Categories.Queries.GetAllCategory;
using PostLand.Application.Features.Categories.Queries.GetCategoryByID;

namespace PostLand.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllCategory")]
        public async Task<ActionResult> GetAllCategory()
        {
            var categories = await _mediator.Send(new GetListCategoryQuery());
            return Ok(categories);
        }

        [HttpGet("GetCategoryByID/{id:int}")]
        public async Task<ActionResult> GetCategoryByID([FromRoute] int id)
        {
            var categories = await _mediator.Send(new GetCategoryByIDQuery(id));
            return Ok(categories);
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory([FromBody] CreateCategoryCommand command)
        {
            var category = await _mediator.Send(command);
            return Ok(category);
        }

        [HttpDelete("{id}", Name = "DeleteCategory")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            var category = await _mediator.Send(new DeleteCategoryCommand(id));
            return Ok(category);
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryCommand command)
        {
            var category = await _mediator.Send(command);
            return Ok(category);
        }

    }
}
