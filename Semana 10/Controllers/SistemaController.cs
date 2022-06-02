using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi01.Models;
using WebApi01.Services;

namespace WebApi01.Controllers;

[ApiController]
[Route("Sistemas")]
public class SistemaController : ControllerBase
{
    readonly SistemaService _sistemaService;
    
    public SistemaController(SistemaService sistemaService)
    {
        _sistemaService = sistemaService;
    }

    //Início do trecho para alteração
    [HttpGet]
    //Fim do trecho para alteração
    
    public ActionResult<List<Sistema>> Listar()
    {
        //Início do trecho para alteração
         return _sistemaService.Listar();
        //Fim do trecho para alteração
    }

    //Início do trecho para alteração
    [HttpGet("{id}")]
    //Fim do trecho para alteração
    public ActionResult<Sistema> Pesquisar(int codigo)
    {
        //Início do trecho para alteração
        var sistema = _sistemaService.Pesquisar(codigo);
        
        if (sistema is null)
        {
            return NotFound();
        }
        return sistema;
        //Fim do trecho para alteração
    }

    //Início do trecho para alteração
    [HttpPost]
    //Fim do trecho para alteração
    public ActionResult Incluir([FromBody] Sistema sistema)
    {
        //Início do trecho para alteração    
         _sistemaService.Incluir(sistema.Codigo, sistema.Nome);
        return CreatedAtAction(nameof(Incluir), new { id = sistema.Codigo}, sistema);
        //Fim do trecho para alteração        
    }

}
