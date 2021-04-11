using AulaNetCore.Bordas.Repositories;
using AulaNetCore.Bordas.Repositories.Produtos;
using AulaNetCore.Context;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Repositories
{
  public class RepositoryProdutos : Repository, IRepositoryProduto
  {
    public void Add(Produto request)
    {
      _context.produto.Add(request);
      _context.SaveChanges();
    }

    public void Remover(int id)
    {
      var obj = _context.produto.Where(p => p.Id == id).FirstOrDefault();

      if (obj == null)
        throw new System.Exception("Produto nao existe");

      _context.Remove(obj);
      _context.SaveChanges();
    }


  }
}
