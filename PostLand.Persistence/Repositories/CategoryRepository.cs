using PostLand.Application.Contracts;
using PostLand.Domain.Entities;
using PostLand.Persistence.Context;

namespace PostLand.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        protected readonly PostDbContext _dbContext;

        public CategoryRepository(PostDbContext dbContext) : base(dbContext)
        {
            // _dbContext = dbContext;
        }

        //public async Task<Category> AddAsync(Category category)
        //{
        //    await _dbContext.AddAsync(category);
        //    await _dbContext.SaveChangesAsync();
        //    return category;
        //}

        //public async Task<string> DeleteAsync(int categoryId)
        //{
        //    var category = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
        //    if (category != null)
        //    {
        //        _dbContext.Remove(category);
        //        _dbContext.SaveChanges();
        //        return "Done";
        //    }
        //    return "categoryIdNotFound";
        //}

        //public async Task<List<Category>> GetAll()
        //{
        //    return await _dbContext.Categories.ToListAsync();
        //}

        //public async Task<Category> GetCategoryById(int id)
        //{
        //    return await _dbContext.Categories.FirstOrDefaultAsync(e => e.Id == id);

        //}

        //public async Task UpdateAsync(Category category)
        //{
        //    _dbContext.Entry(category).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();

        //}
    }
}
