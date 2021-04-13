using AulaNetCore.Bordas;
using AulaNetCore.Bordas.Repositories.Empresas;
using AulaNetCore.Bordas.Repositories.Produtos;
using AulaNetCore.DTO.Empresa.RemoverEmpresa;
using AulaNetCore.DTO.Produto.RemoverProduto;
using AulaNetCore.UseCase.Empresas;
using AulaNetCore.UseCase.Produtos;
using AulaNetCore.UserCase.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Empresas
{
  public class RemoverEmpresaUseCase : IRemoverEmpresaUseCase
  {
    private readonly IRepositoryEmpresa _repositoryempresa;

    public RemoverEmpresaUseCase(IRepositoryEmpresa repositoryempresa)
    {
      _repositoryempresa = repositoryempresa;
    }

    public RemoverEmpresaResponse Executar(RemoverEmpresaRequest T)
    {
      var response = new RemoverEmpresaResponse();

      try
      {

        response.msg = "Empresa removida com sucesso";

        _repositoryempresa.Remover(T.id);
        return response;
      }
      catch
      {
        response.msg = "Erro ao remover empresa";
        return response;
      }

    }


  }
}
