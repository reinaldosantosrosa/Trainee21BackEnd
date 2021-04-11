using AulaNetCore.Bordas;
using AulaNetCore.Bordas.Adapter;
using AulaNetCore.DTO.Empresa.AdicionarEmpresa;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Adapter.Empresas
{
  public class AdicionarEmpresaAdapter : IAdicionarEmpresaAdapter
  {
    public Empresa ConverterRequestParaEmpresa(AdicionarEmpresaRequest request)
    {
      throw new NotImplementedException();
    }

    //public Produto ConverterRequestParaProduto(AdicionarProdutoRequest request)
    //{
    //  var p = new Produto();
    //  p.Descricao = request.Descricao;
    //  return p;
    //}

  }
}

