using AulaNetCore.Bordas;
using AulaNetCore.Bordas.Repositories.Produtos;
using AulaNetCore.DTO.Produto.RemoverProduto;
using AulaNetCore.UseCase.Produtos;
using AulaNetCore.UserCase.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Produto
{
  public class RemoverProdutoUseCase : IRemoverProdutoUseCase
  {
    private readonly IRepositoryProduto _repositoryprodutos;

    public RemoverProdutoUseCase(IRepositoryProduto repositoryprodutos)
    {
      _repositoryprodutos = repositoryprodutos;
    }

    public RemoverProdutoResponse Executar(RemoverProdutRequest T)
    {
      var response = new RemoverProdutoResponse();

      try
      {
   
        response.msg = "Removido com sucesso";

        _repositoryprodutos.Remover(T.id);

        return response;
      } catch
      {
        response.msg = "Erro ao remover produto";
        return response;
      }
    }


  }
}
