using AulaNetCore.Bordas;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.UseCase.Empresas
{



  public interface IAdicionarEmpresaUseCase

  {
    public AdicionarEmpresaResponse Executar(AdicionarEmpresaRequest T);
  }
}
