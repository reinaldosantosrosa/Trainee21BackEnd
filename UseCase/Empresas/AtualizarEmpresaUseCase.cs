using AulaNetCore.Adapter.Empresas;
using AulaNetCore.Bordas.Adapter;
using AulaNetCore.Bordas.Repositories.Empresas;
using AulaNetCore.DTO.Empresa.AdicionarEmpresa;
using AulaNetCore.DTO.Empresa.AtualizarEmpresa;
using AulaNetCore.DTO.Produto.AtualizarProduto;

using AulaNetCore.UseCase.Empresas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Empresas
{
  public class AtualizarEmpresaUseCase : IAtualizarEmpresaUseCase
  {
    private readonly IRepositoryEmpresa _repositoryEmpresa;
   


    public AtualizarEmpresaUseCase(IRepositoryEmpresa repositoryEmpresa)
    {
      _repositoryEmpresa = repositoryEmpresa;
   
    }

    public AtualizarEmpresaResponse Executar(AtualizarEmpresaRequest T)
    {
      var response = new AtualizarEmpresaResponse();

      try
      {
       response.msg = "Empresa atualizada com sucesso";
       _repositoryEmpresa.Atualizar(T);
       
        return response;
      }
      catch(Exception e)
      {
        response.msg = e.Message;
        return response;
      }
    }

  }
}
