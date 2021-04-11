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

namespace AulaNetCore.UseCase.Empresa
{
  public class RemoverEmpresaUseCase : IRemoverEmpresaUseCase
  {
    private readonly IRepositoryEmpresa _repositoryempresa;

    public RemoverEmpresaResponse Executar(RemoverEmpresaRequest T)
    {
      throw new NotImplementedException();
    }

    //public RemoverProdutoResponse Executar(RemoverProdutRequest T)
    //{
    //  var response = new RemoverProdutoResponse();

    //  try
    //  {

    //    response.msg = "Removido com sucesso";

    //    _repositoryprodutos.Remover(T.id);
    //    return response;
    //  } catch
    //  {
    //    response.msg = "Erro ao remover produto";
    //    return response;
    //  }
    //}


  }
}
