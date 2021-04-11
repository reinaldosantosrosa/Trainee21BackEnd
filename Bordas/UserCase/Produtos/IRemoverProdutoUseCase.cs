using AulaNetCore.Bordas;
using AulaNetCore.DTO.Produto.RemoverProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Produto
{
  public interface IRemoverProdutoUseCase
  {
    public RemoverProdutoResponse Executar(RemoverProdutRequest T);
  }
}
