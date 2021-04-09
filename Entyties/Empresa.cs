using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Entities
{
  public class Empresa
  {
    [Key]
    public int Id { get; set; }

    public string CNPJ { get; set; }

    public string RazaoSocial { get; set; }

    public string NomeFantasia { get; set; }

    public string InscricaoEstadual { get; set; }
  }
}
