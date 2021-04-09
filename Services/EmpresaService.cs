using AulaNetCore.Context;
using AulaNetCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Services
{
  public class EmpresaService : IEmpresaService
  {
    private readonly LocalDbContext _Local;

    public EmpresaService(LocalDbContext local)
    {
      _Local = local;
    }

    public bool AdicionaEmpresa(Empresa empresa)
    {
      _Local.Add(empresa);
      _Local.SaveChanges();
      return true;
    }

    public bool AtualizaEmpresa(Empresa empresa)
    {
      _Local.empresa.Attach(empresa);
      _Local.Entry(empresa).State = EntityState.Modified;
      _Local.SaveChanges();
      return true;
    }

    public bool DeletarEmpresa(int id)
    {
      _Local.empresa.Remove(ObterPorId(id));
      _Local.SaveChanges();

      return true;
    }
    

    public IList<Empresa> ObterTodasEmpresas()
    {
       return _Local.empresa.ToList();
    }

    public Empresa ObterPorId(int id)
    {
      return _Local.empresa.Where(p => p.Id == id).FirstOrDefault();
    }


  }
}
