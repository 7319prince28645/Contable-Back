using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Infrastructure.Persistence;
using Contable.Infrastructure.Persistence.Repository.UserRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Contable.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ContextContable>(options =>
            options.UseSqlServer("Server=DESKTOP-MANMUAE\\SQLSERVER;Database=Contable;Trusted_Connection=True;TrustServerCertificate=True;"));

        services.AddTransient<IUserCommandRepository, UserCommandRepository>();

        services.AddTransient<IUserQueryRepository, UserQueryRepository>();
        return services;
    }
}
