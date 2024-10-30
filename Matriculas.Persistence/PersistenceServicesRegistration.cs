using Matriculas.Application.Contracts.Persistence;
using Matriculas.Application.Contracts.Persistence.Commons;
using Matriculas.Persistence.Repositories;
using Matriculas.Persistence.Repositories.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Matriculas.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("SqlDatabase"));
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            return services;
        }
    }
}
