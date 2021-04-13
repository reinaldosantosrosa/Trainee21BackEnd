using AulaNetCore.Bordas;
using AulaNetCore.DTO.Empresa.RetornarEmpresaPorId;
using AulaNetCore.DTO.Empresa.RetornarListaDeEmpresa;
using AulaNetCore.DTO.Produto.RetornarListaDeProduto;
using AulaNetCore.Entities;
using AulaNetCore.UseCase.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Empresas
{
  public interface IRetornarListaDeEmpresaUseCase

  {

    public IList<Empresa> Executar(RetornarListaDeEmpresaRequest request);

  }
}
