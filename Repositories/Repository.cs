using AulaNetCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Repositories
{
  public abstract class Repository
  {
    protected LocalDbContext context ;

    protected Repository(LocalDbContext context)
    {
      this.context = context;
    }

  }
}
