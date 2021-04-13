using AulaNetCore.Bordas.Repositories;
using AulaNetCore.Bordas.Repositories.Empresas;
using AulaNetCore.Bordas.Repositories.Produtos;
using AulaNetCore.Context;
using AulaNetCore.DTO.Empresa.AtualizarEmpresa;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using Microsoft.EntityFrameworkCore;
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

    //public void Atualizar(Empresa request)
    //{

    //  context.empresa.Attach(request);
    //  context.Entry(request).State = EntityState.Modified;
    //  context.SaveChanges();
    //}

    public void Atualizar(AtualizarEmpresaRequest request)
    {
      var obj = context.empresa.Where(p => p.Id == request.id).FirstOrDefault();

      if (obj == null)
        throw new System.Exception("A Empresa não foi localizada");


      obj.CNPJ = request.CNPJ;
      obj.InscricaoEstadual = request.InscricaoEstadual;
      obj.NomeFantasia = request.NomeFantasia;
      obj.RazaoSocial = request.RazaoSocial;

      context.Update(obj);
      context.SaveChanges();
    }

    public Empresa ObterPorId(int id)
    {
      var obj = context.empresa.Where(p => p.Id == id).FirstOrDefault();

      if (obj == null)
        throw new System.Exception("Empresa não foi locaizada");

      return obj;
    }


    public IList<Empresa> ObterTodos()
    {
      return context.empresa.ToList();
    }

    public void Remover(int id)
    {
      var obj = context.empresa.Where(p => p.Id == id).FirstOrDefault();

      if (obj == null)
        throw new System.Exception("Produto nao existe");

      context.Remove(obj);
      context.SaveChanges();
    }


  }
}
