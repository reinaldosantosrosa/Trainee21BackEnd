using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNetCore.Entities;
using AulaNetCore.Services;
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

    public ProdutoController(ILogger<ProdutoController> logger, IProdutoService produtoservice)
    {
      _loger = logger;
      _produtoservice = produtoservice;
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
    public IActionResult AddProduto([FromBody] Produto produto)
    {
      return Ok(_produtoservice.AdicionaProduto(produto));
    }

    [HttpPut]
    public IActionResult UpdateProduto([FromBody] Produto produto)
    {
      return Ok(_produtoservice.AtualizaProduto(produto));
    }

    [HttpDelete("{id}")]

    public IActionResult DeleteProduto(int id)
    {
      return Ok(_produtoservice.DeletarProduto(id));
    }


  }
}
