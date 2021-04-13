using AulaNetCore.Bordas;
using AulaNetCore.DTO.Produto.RetornarProdutoPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Produtos
{
  public interface IRetornarProdutoPorIdUseCase 
  {
    public RetornarProdutoPorIdResponse Executar(RetornarProdutoPorIdRequest T);
  }
}
