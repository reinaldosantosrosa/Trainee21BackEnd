using AulaNetCore.Bordas.Repositories;
using AulaNetCore.Bordas.Repositories.Empresas;
using AulaNetCore.Bordas.Repositories.Produtos;
using AulaNetCore.Context;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace AulaNetCore.Repositories.Empresas
{
  
  public class RepositoryEmpresa : Repository, IRepositoryEmpresa
  {
    public RepositoryEmpresa(LocalDbContext context) : base(context)
    {

    }

    public void Add(Empresa request)
    {
      context.empresa.Add(request);
      context.SaveChanges();
    }

    public void Remover(int id)
    {
      throw new NotImplementedException();
    }
  }
}
