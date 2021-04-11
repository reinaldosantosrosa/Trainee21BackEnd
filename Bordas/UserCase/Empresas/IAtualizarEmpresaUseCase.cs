using AulaNetCore.Bordas;
using AulaNetCore.DTO.Produto.AtualizarProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Produto
{
  public interface IAtualizarEmpresaUseCase
  {
    public AtualizarEmpresaResponse executar(AtualizarEmpresaRequest T);

  }
}
