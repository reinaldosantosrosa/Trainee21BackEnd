using AulaNetCore.Context;
using AulaNetCore.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Services
{
  public class ProdutoService : IProdutoService
  {

    private readonly LocalDbContext _Local;

    public  ProdutoService(LocalDbContext local){
      _Local = local;
      }

    public bool AdicionaProduto(Produtos produto)
    {
      _Local.Add(produto);
      _Local.SaveChanges();
      return true;
    }

    public bool AtualizaProduto(Produtos produto)
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

    public Produtos ObterPorId(int id)
    {
      return _Local.produto.Where(p => p.Id == id).FirstOrDefault();
    }

    public IList<Produtos> ObterTodosProdutos()
    {
      return _Local.produto.ToList();
    }
  }
}
