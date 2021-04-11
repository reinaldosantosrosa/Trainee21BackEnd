using AulaNetCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Bordas.Repositories
{
  public  interface IRepository<Entity>
  {
    public void Add(Entity request);
    public void Remover(int id);
  }
}
