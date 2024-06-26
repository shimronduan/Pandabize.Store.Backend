using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pandabize.Store.Application.Contracts.Persistance;
using Pandabize.Store.Persistence.Repositories;

namespace Pandabize.Store.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PandabizeStoreDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("PandabizeStoreConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            return services;
        }
    }
}
