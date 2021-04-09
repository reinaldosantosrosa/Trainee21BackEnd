using AulaNetCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Context
{
  public class LocalDbContext: DbContext
  {

    public LocalDbContext(DbContextOptions<LocalDbContext> opt): base(opt)
    {

    }

    public DbSet<Produto> produto { get; set; }

    public DbSet<Empresa> empresa { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
     
    }

  }
}
