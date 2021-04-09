using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Services
{
  public interface IEmpresaService
  {
    bool AdicionaEmpresa(Empresa empresa);
    bool AtualizaEmpresa(Empresa empresa);

    bool DeletarEmpresa(int id);

    IList<Empresa> ObterTodasEmpresas();

    Empresa ObterPorId(int id);
  }
}
