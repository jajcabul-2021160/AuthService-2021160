using AuthServiceIN6BM.Domain.Interfaces;
using AuthServiceIN6BM.Persistence.Data;
using AuthServiceIN6BM.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AuthServiseIN6BM.Api.Extensions;

public static class ServiceCollectionExtensions
{
 public static IserviceCollection AddAplicationServices(this IServiceCollection services, IConfiguration configuration)
 {
services.AddDbContext<ApplicatoDbContext>(options =>
 options.UserNpgsql(configuration.GetConnectionString("DefaultConnection"))
 .userSnakeCaseNamingConventions()
);

services.AddScoped<IUserRepository, UserRepository>();
services.AddScoped<IRoleRepository, RoleRepository>();

services.AddHealthChecks();

return services;
 }

 public static IServiceCollection AddApiDocumentation(this IServiceCollection services){

    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

    return services;
 }
}

