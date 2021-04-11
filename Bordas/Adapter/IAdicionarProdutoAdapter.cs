using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Bordas.Adapter
{
  public interface IAdicionarProdutoAdapter
  {
    public Produto ConverterRequestParaProduto(AdicionarProdutoRequest request);
  }
}
