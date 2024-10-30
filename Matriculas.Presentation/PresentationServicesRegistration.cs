using Matriculas.Application;
using Matriculas.Presentation.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Matriculas.Presentation
{
    public static class PresentationServicesRegistration
    {
        public static IServiceCollection AddPresentationServices(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddApplicationServices();

            return services;
        }

        public static IApplicationBuilder UsePresentationMiddlewares(this IApplicationBuilder application)
        {
            application.UseMiddleware<ExceptionMiddleware>();
            return application;
        }
    }
}
