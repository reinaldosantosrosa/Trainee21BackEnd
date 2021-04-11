using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.DTO.Empresa.AdicionarEmpresa
{
  public class AdicionarEmpresaRequest
  {
    public string CNPJ { get; set; }

    public string RazaoSocial { get; set; }

    public string NomeFantasia { get; set; }
  }
}
