using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stock.Infra.Data.Context;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Application.Mappings;
using Stock.Domain.Interfaces;
using Stock.Infra.Data.Repositories;
using Stock.Application.Interfaces;
using Stock.Application.Services;
using AutoMapper;

namespace Stock.Infra.loc
{
    public static class DependentionInjection
    {
        public static IServiceCollection AddInfrastruture(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(Options =>
            {
                 Options.UseNpgsql("Host=localhost;port=5434;Database=stock;Username=postgres;Password=1234;",
                  b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));

            });

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
            //Repositories
            services.AddScoped<IUsuarioRepository,UsuarioRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            
            //Serviços
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }   
     }
}
