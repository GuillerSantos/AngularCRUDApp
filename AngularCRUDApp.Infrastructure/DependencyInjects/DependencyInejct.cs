﻿using AngularCRUDApp.Application.Common.Interfaces;
using AngularCRUDApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AngularCRUDApp.Infrastructure.DependencyInjects
{
    public static class DependencyInject
    {
        #region Public Methods

        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            AddPersistence(services, configuration);

            return services;
        }

        #endregion Public Methods

        #region Private Methods

        private static void AddPersistence(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection")!;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(configuration), "Database Connection String Is Missing!!!!!!!");
            }

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

            services.AddHttpContextAccessor();

            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                options.UseSqlServer(connectionString)
                       .LogTo(Console.WriteLine, LogLevel.Information)
                       .UseLazyLoadingProxies();
            });
        }

        #endregion Private Methods
    }
}