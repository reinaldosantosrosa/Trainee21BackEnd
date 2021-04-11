using AulaNetCore.Bordas;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Produtos
{

  public interface IAdicionarProdutoUseCase

  {
    public AdicionarProdutoResponse Executar(AdicionarProdutoRequest T);
  }
}
