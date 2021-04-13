using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.DTO.Empresa.AtualizarEmpresa
{
  public class AtualizarEmpresaRequest
  {
    public int id { get; set; }

    public string CNPJ { get; set; }

    public string RazaoSocial { get; set; }

    public string NomeFantasia { get; set; }

    public string InscricaoEstadual { get; set; }
  }
}
