using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Services
{
  public interface IProdutoService
  {
    bool AdicionaProduto(Produto produto);
    bool AtualizaProduto(Produto produto);

    bool DeletarProduto(int id);

    IList<Produto> ObterTodosProdutos();

    Produto ObterPorId(int id);



  }
}
