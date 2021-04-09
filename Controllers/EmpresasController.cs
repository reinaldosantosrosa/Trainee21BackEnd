using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNetCore.Entities;
using AulaNetCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AulaNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
    private readonly ILogger<EmpresasController> _loger;
    private readonly IEmpresaService _empresaservice;
   


    public EmpresasController(ILogger<EmpresasController> loger, IEmpresaService empresaservice)
    {
      _loger = loger;
      _empresaservice = empresaservice;
    }

    [HttpGet]
    public IActionResult ObterTodosProdutos()
    {
      return Ok(_empresaservice.ObterTodasEmpresas());
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
      return Ok(_empresaservice.ObterPorId(id));
    }

    [HttpPost]
    public IActionResult AddProduto([FromBody] Empresa empresa)
    {
      return Ok(_empresaservice.AdicionaEmpresa(empresa));
    }

    [HttpPut]
    public IActionResult UpdateProduto([FromBody] Empresa empresa)
    {
      return Ok(_empresaservice.AtualizaEmpresa(empresa));
    }

    [HttpDelete("{id}")]

    public IActionResult DeleteProduto(int id)
    {
      return Ok(_empresaservice.DeletarEmpresa(id));
    }


  }
}
