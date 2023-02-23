﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infrastructure.Persistences.Contexts;

namespace POS.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(DBRESTAURANTEContext).Assembly.FullName;
            services.AddDbContext<DBRESTAURANTEContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("DBConnection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient );
            return services;
        }
    }
}
