using AulaNetCore.DTO.Empresa.AtualizarEmpresa;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Bordas.Repositories.Empresas
{
  public interface IRepositoryEmpresa: IRepository<Empresa>
  {
    public void Atualizar(AtualizarEmpresaRequest request);
  }
}
