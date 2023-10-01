using PostLand.Application.Contracts.Persistence;
using PostLand.Domain.Entities;

namespace PostLand.Application.Contracts
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        //Task<List<Category>> GetAll();
        //Task<Category> GetCategoryById(int id);
        //Task<Category> AddAsync(Category category);
        //Task UpdateAsync(Category category);
        //Task<string> DeleteAsync(int categoryId);
    }
}
