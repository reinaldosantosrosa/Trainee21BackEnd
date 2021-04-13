using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.DTO.Produto.RemoverProduto;
using AulaNetCore.Entities;
using AulaNetCore.Services;
using AulaNetCore.UseCase.Produto;
using AulaNetCore.UseCase.Produtos;
using AulaNetCore.UserCase.Produtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AulaNetCore.Controllers
{
  


  [ApiController]
  [Route("[controller]")]
  public class ProdutoController : ControllerBase
  {
    private readonly ILogger<ProdutoController> _loger;
    private readonly IProdutoService _produtoservice;
    private readonly IAdicionarProdutoUseCase _adicionarproduto;
    private readonly IRemoverProdutoUseCase _removerProduto;

    public ProdutoController(ILogger<ProdutoController> logger, IProdutoService produtoservice, IAdicionarProdutoUseCase adicionarproduto, IRemoverProdutoUseCase removerProduto)
    {
      _loger = logger;
      _produtoservice = produtoservice;
      _adicionarproduto = adicionarproduto;
      _removerProduto = removerProduto;
    }

    [HttpGet]
    public IActionResult ObterTodosProdutos()
    {
      return Ok(_produtoservice.ObterTodosProdutos());
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
      return Ok(_produtoservice.ObterPorId(id));
    }

    [HttpPost]
    public IActionResult AddProduto([FromBody] AdicionarProdutoRequest produto)
    {
      return Ok(_adicionarproduto.Executar(produto));
    }

    [HttpPut]
    public IActionResult UpdateProduto([FromBody] Produto produto)
    {
   
      return Ok(_produtoservice.AtualizaProduto(produto));
    }



    [HttpDelete("{id}")]

    public IActionResult DeleteProduto(int id)
    {
      var request =new RemoverProdutRequest();
      request.id = id;
      return Ok(_removerProduto.Executar(request));
    }


  }
}
