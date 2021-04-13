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
  public class RepositoryProdutos :  IRepositoryProduto
  {
    private LocalDbContext _context;
    public RepositoryProdutos(LocalDbContext local)
    {
      _context = local;
    
    }
    public void Add(Produto request)
    {
      _context.produto.Add(request);
      _context.SaveChanges();
    }

    public void Atualizar(Produto request)
    {
      throw new NotImplementedException();
    }

    public Produto ObterPorId(int id)
    {
      var obj = _context.produto.Where(p => p.Id == id).FirstOrDefault();

      if (obj == null)
        throw new System.Exception("Produto nao existe");

      return obj;
    }

    public IList<Produto> ObterTodos()
    {
      throw new NotImplementedException();
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
