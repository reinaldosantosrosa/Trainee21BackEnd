using AulaNetCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Repositories
{
  public class Repository
  {
    public LocalDbContext _context;
    public LocalDbContext RepositoryEmpresas(LocalDbContext local)
    {
      _context = local;
      return _context;
    }
  }
}
