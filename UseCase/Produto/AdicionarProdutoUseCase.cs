using AulaNetCore.Bordas;
using AulaNetCore.Bordas.Adapter;
using AulaNetCore.Bordas.Repositories;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Produto
{
  public class AdicionarProdutoUseCase : IAdicionarEmpresaUseCase
  {
    private readonly IRepositoryProduto _repositoryProduto;
    private readonly IAdicionarProdutoAdapter _adapter;

    public AdicionarProdutoUseCase(IRepositoryProduto repositoryProduto, IAdicionarProdutoAdapter adapter)
    {
      _repositoryProduto = repositoryProduto;
      _adapter = adapter;
    }


    public AdicionarProdutoResponse Executar(AdicionarProdutoRequest T)
    {
      var response = new AdicionarProdutoResponse();

      try
      {
        var produtoAdd = _adapter.ConverterRequestParaProduto(T);
        _repositoryProduto.Add(produtoAdd);
        response.msg = "Adicionado";
        return response;
      }
      catch
      {
        response.msg = "Nao adicionado";
        return response;
      }

    }


  }
}
