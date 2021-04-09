using AulaNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNetCore.Services
{
  public interface IProdutoService
  {
    bool AdicionaProduto(Produtos produto);
    bool AtualizaProduto(Produtos produto);

    bool DeletarProduto(int id);

    IList<Produtos> ObterTodosProdutos();

    Produtos ObterPorId(int id);



  }
}
