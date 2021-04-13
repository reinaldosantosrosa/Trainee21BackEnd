using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNetCore.Bordas.Repositories.Empresas;
using AulaNetCore.DTO.Empresa.AdicionarEmpresa;
using AulaNetCore.DTO.Empresa.AtualizarEmpresa;
using AulaNetCore.DTO.Empresa.RemoverEmpresa;
using AulaNetCore.DTO.Empresa.RetornarEmpresaPorId;
using AulaNetCore.DTO.Empresa.RetornarListaDeEmpresa;
using AulaNetCore.DTO.Produto.AdicionarProduto;
using AulaNetCore.Entities;
using AulaNetCore.Services;

using AulaNetCore.UseCase.Empresas;
using AulaNetCore.UserCase.Empresas;
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
    private readonly IRemoverEmpresaUseCase _removerEmpresaUseCase;
    private readonly IAtualizarEmpresaUseCase _atualizarEmpresaUseCase;
    private readonly IRetornarEmpresaPorIdUseCase _obterPorId;
    private readonly IRetornarListaDeEmpresaUseCase _obterListaEmpresa;
    //adas


    public EmpresasController(ILogger<EmpresasController> loger, IEmpresaService empresaservice, IAdicionarEmpresaUseCase adicionarEmpresaUsecase, IRemoverEmpresaUseCase removerEmpresaUseCase, IAtualizarEmpresaUseCase atualizarEmpresaUseCase, IRetornarEmpresaPorIdUseCase obterPorId, IRetornarListaDeEmpresaUseCase obterListaEmpresa)
    {
      _loger = loger;
      _empresaservice = empresaservice;
      _adicionarEmpresaUsecase = adicionarEmpresaUsecase;

      _removerEmpresaUseCase = removerEmpresaUseCase;
      _atualizarEmpresaUseCase = atualizarEmpresaUseCase;

      _obterPorId = obterPorId;
      _obterListaEmpresa = obterListaEmpresa;
    }


    [HttpGet]
    public IActionResult ObterListaDeEmpresas()
    {

      var request = new RetornarListaDeEmpresaRequest();

      return Ok(_obterListaEmpresa.Executar(request));
     // return Ok(_empresaservice.ObterTodasEmpresas());
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
      var request = new RetornarEmpresaPorIdRequest();
      request.id = id;
      return Ok(_obterPorId.Executar(request));

     // return Ok(_empresaservice.ObterPorId(id));
    }

    [HttpPost]
    public IActionResult AddEmpresa([FromBody] AdicionarEmpresaRequest empresa)
    {
   
      return Ok(_adicionarEmpresaUsecase.Executar(empresa));
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduto([FromBody] AtualizarEmpresaRequest empresa, int id)
    {

      empresa.id = id;
      return Ok(_atualizarEmpresaUseCase.Executar(empresa));
    }

    [HttpDelete("{id}")]

    public IActionResult DeleteProduto(int id)
    {
      //return Ok(_empresaservice.DeletarEmpresa(id));

      var request = new RemoverEmpresaRequest();
      request.id = id;
      return Ok(_removerEmpresaUseCase.Executar(request));

    }


  }
}
