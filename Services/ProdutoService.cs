using AulaNetCore.Context;
using AulaNetCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AulaNetCore.Services
{
  public class ProdutoService : IProdutoService
  {

    private readonly LocalDbContext _Local;

    public  ProdutoService(LocalDbContext local){
      _Local = local;
      }

    public bool AdicionaProduto(Produto produto)
    {
      _Local.Add(produto);
      _Local.SaveChanges();
      return true;
    }

    public bool AtualizaProduto(Produto produto)
    {
      _Local.produto.Attach(produto);
      _Local.Entry(produto).State = EntityState.Modified;
      _Local.SaveChanges();
      return true;
    }

    public bool DeletarProduto(int id)
    {
      _Local.produto.Remove(ObterPorId(id));
      _Local.SaveChanges();

      return true;
    }

    public Produto ObterPorId(int id)
    {
      return _Local.produto.Where(p => p.Id == id).FirstOrDefault();
    }

    public IList<Produto> ObterTodosProdutos()
    {
      return _Local.produto.ToList();
    }
  }
}
