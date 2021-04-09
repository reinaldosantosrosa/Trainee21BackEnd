using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Entities
{
  public class Produto
  {
    [Key]
    public int Id { get; set; }
    public string Descricao { get; set; }
  }
}
