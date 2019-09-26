using Gol.Teste.Domain.Contratos.Repositorios;
using Gol.Teste.Domain.Contratos.Servicos;
using Gol.Teste.Infra.EF;
using Gol.Teste.Infra.Repositorios;
using Gol.Teste.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Gol.Teste.IoC
{
    public static class DI
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            //var connectionString = "Data Source=(local);Initial Catalog=db_gol;Integrated Security=True;MultipleActiveResultSets=True";
            var connectionString = "Data Source=(local);Initial Catalog=db_gol;User Id=admin; Password=Inter@2019";

            services.AddDbContext<Contexto>(options => options.UseSqlServer(connectionString));
            services.AddTransient<IAirplaneRepository, AirplaneRepository>();
            services.AddTransient<IAirplaneService, AirplaneService>();

            return services;
        }
    }
}
