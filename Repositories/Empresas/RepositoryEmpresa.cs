using AulaNetCore.Bordas.Repositories;
using AulaNetCore.Bordas.Repositories.Empresas;
using AulaNetCore.Bordas.Repositories.Produtos;
using AulaNetCore.Context;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Repositories.Empresas
{
  

  public class RepositoryEmpresas : Repository, IRepositoryEmpresa
  {
     public void Add(Empresa request)
    {
      _context.empresa.Add(request);
      _context.SaveChanges();
    }

  }
}
