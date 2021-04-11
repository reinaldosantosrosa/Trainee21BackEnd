using AulaNetCore.Bordas;
using AulaNetCore.Bordas.Adapter;
using AulaNetCore.Bordas.Repositories;
using AulaNetCore.Bordas.Repositories.Empresas;
using AulaNetCore.Bordas.Repositories.Produtos;
using AulaNetCore.DTO.Empresa.AdicionarEmpresa;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.UseCase.Empresas;
using AulaNetCore.UseCase.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Produto
{
  public class AdicionarEmpresaUseCase : IAdicionarEmpresaUseCase
  {
    private readonly IRepositoryEmpresa _repositoryEmpresa;
    private readonly IAdicionarEmpresaAdapter _adapter;

    public AdicionarEmpresaUseCase(IRepositoryEmpresa repositoryEmpresa, IAdicionarEmpresaAdapter adapter)
    {
      _repositoryEmpresa = repositoryEmpresa;
      _adapter = adapter;
    }


    public AdicionarEmpresaResponse Executar(AdicionarEmpresaRequest T)
    {
      var response = new AdicionarEmpresaResponse();

      try
      {
        var empresaAdd = _adapter.ConverterRequestParaEmpresa(T);
        _repositoryEmpresa.Add(empresaAdd);
        response.msg = "Empresa adcionada";
        return response;
      }
      catch
      {
        response.msg = "Erro ao adicionar empresa";
        return response;
      }
    }
  }
}
