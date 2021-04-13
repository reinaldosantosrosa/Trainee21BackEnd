using AulaNetCore.Bordas.Repositories.Empresas;
using AulaNetCore.DTO.Empresa.RetornarEmpresaPorId;
using AulaNetCore.DTO.Produto.RetornarProdutoPorId;
using AulaNetCore.UseCase.Empresas;
using AulaNetCore.UseCase.Produto;
using AulaNetCore.UserCase.Empresas;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Empresas
{
  public class RetornarEmpresaPorIdUseCase : IRetornarEmpresaPorIdUseCase
  {
    private readonly IRepositoryEmpresa _repositoryempresa;

    public RetornarEmpresaPorIdUseCase(IRepositoryEmpresa repositoryempresa)
    {
      _repositoryempresa = repositoryempresa;
    }

    public Entities.Empresa Executar(RetornarEmpresaPorIdRequest T)
    {
      return _repositoryempresa.ObterPorId(T.id);
    }
  }
}
