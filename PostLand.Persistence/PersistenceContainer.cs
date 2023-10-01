using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PostLand.Application.Contracts;
using PostLand.Application.Contracts.Persistence;
using PostLand.Persistence.Context;
using PostLand.Persistence.Repositories;

namespace PostLand.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<PostDbContext>(options =>
                options.UseSqlServer("Data Source=DESKTOP-C6QMATS;Initial Catalog=PostLandDb;Integrated Security=True;TrustServerCertificate=True;"));

            services.AddTransient(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddTransient(typeof(IPostRepository), typeof(PostRepository));
            services.AddTransient(typeof(ICategoryRepository), typeof(CategoryRepository));



            return services;
        }
    }

}
