using AulaNetCore.Bordas.Repositories.Empresas;
using AulaNetCore.DTO.Empresa.RetornarListaDeEmpresa;
using AulaNetCore.Entities;
using AulaNetCore.UseCase.Empresas;
using System;
using System.Collections.Generic;

namespace AulaNetCore.UseCase.Empresas
{
  public class RetornarListaDeEmpresaUseCase : IRetornarListaDeEmpresaUseCase
  {
    private readonly IRepositoryEmpresa _repositoryempresa;

    public RetornarListaDeEmpresaUseCase(IRepositoryEmpresa repositoryempresa)
    {
      _repositoryempresa = repositoryempresa;
    }


    public IList<Empresa> Executar(RetornarListaDeEmpresaRequest request)
    {
      return _repositoryempresa.ObterTodos();

    }
  }
}
