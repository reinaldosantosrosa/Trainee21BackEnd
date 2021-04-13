using AulaNetCore.Bordas;
using AulaNetCore.DTO.Empresa.RetornarEmpresaPorId;
using AulaNetCore.DTO.Produto.RetornarProdutoPorId;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UserCase.Empresas
{
  public interface IRetornarEmpresaPorIdUseCase 
  {
    public Empresa Executar(RetornarEmpresaPorIdRequest T);
  }
}
