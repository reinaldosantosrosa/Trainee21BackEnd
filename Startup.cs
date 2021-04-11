using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNetCore.Adapter.Produtos;
using AulaNetCore.Bordas.Adapter;
using AulaNetCore.Bordas.Repositories;
using AulaNetCore.Bordas.Repositories.Produtos;
using AulaNetCore.Context;
using AulaNetCore.Repositories;
using AulaNetCore.Services;
using AulaNetCore.UseCase.Produto;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AulaNetCore
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql
           (Configuration.GetConnectionString("urlsquadra")));

      
      //Empresas
      services.AddScoped<IEmpresaService, EmpresaService>();

      //dependencie injection Produto
      services.AddScoped<IProdutoService, ProdutoService>();
      services.AddScoped<IAdicionarProdutoUseCase, AdicionarProdutoUseCase>();
      services.AddScoped<IAtualizarEmpresaUseCase, AtualizarProdutoUseCase>();
      services.AddScoped<IRemoverProdutoUseCase, RemoverProdutoUseCase>();
      services.AddScoped<IRetornarListaDeProdutoUseCase, RetornarListaDeProdutoUseCase>();
      services.AddScoped<IRetornarProdutoPorIdUseCase, RetornarProdutoPorIdUseCase>();
      services.AddScoped<IRepositoryProduto, RepositoryProdutos>();
      services.AddScoped<IAdicionarProdutoAdapter, AdicionarProdutoAdapter>();

      services.AddControllers();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
