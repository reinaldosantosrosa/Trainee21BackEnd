using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNetCore.DTO.Empresa.AdicionarEmpresa;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using AulaNetCore.Services;
using AulaNetCore.UseCase.Empresas;
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
    private readonly IAdicionarEmpresaUseCase _adicionarEmpresaUsecase;
    //adas


    public EmpresasController(ILogger<EmpresasController> loger, IEmpresaService empresaservice, IAdicionarEmpresaUseCase adicionarEmpresaUsecase)
    {
      _loger = loger;
      _empresaservice = empresaservice;
      _adicionarEmpresaUsecase = adicionarEmpresaUsecase;
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
    public IActionResult AddEmpresa([FromBody] Empresa empresa)
    {
      return Ok(_empresaservice.AdicionaEmpresa(empresa));
    }

    [HttpPut]
    public IActionResult UpdateProduto([FromBody] AdicionarEmpresaRequest empresa)
    {
      return Ok(_adicionarEmpresaUsecase.Executar(empresa));
    }

    [HttpDelete("{id}")]

    public IActionResult DeleteProduto(int id)
    {
      return Ok(_empresaservice.DeletarEmpresa(id));
    }


  }
}
