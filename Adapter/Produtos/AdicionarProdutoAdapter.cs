using AulaNetCore.Bordas;
using AulaNetCore.Bordas.Adapter;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Adapter.Produtos
{
  public class AdicionarProdutoAdapter : IAdicionarProdutoAdapter
  {

    public Produto ConverterRequestParaProduto(AdicionarProdutoRequest request)
    {
      var p = new Produto();
      p.Descricao = request.Descricao;
      return p;
    }

  }
}

