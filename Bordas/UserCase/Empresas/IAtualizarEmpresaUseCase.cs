using AulaNetCore.Bordas;
using AulaNetCore.DTO.Empresa.AtualizarEmpresa;
using AulaNetCore.DTO.Produto.AtualizarProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Empresas
{
  public interface IAtualizarEmpresaUseCase
  {
    public AtualizarEmpresaResponse Executar(AtualizarEmpresaRequest T);

  }
}
