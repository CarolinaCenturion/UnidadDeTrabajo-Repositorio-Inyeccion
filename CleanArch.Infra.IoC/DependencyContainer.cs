using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using ClearArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUniteOfWork, UnitOfWork>();

            return services;
        }
    }
}
