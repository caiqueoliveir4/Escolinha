using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi01.Models;
using WebApi01.Services;

namespace WebApi01.Controllers;

[ApiController]
[Route("Estrelas")]
public class EstrelaController : ControllerBase
{
    readonly EstrelaService _estrelaService;
    
    public EstrelaController(EstrelaService estrelaService)
    {
        _estrelaService = estrelaService;
    }

    //Início do trecho para alteração
    [HttpGet]
    //Fim do trecho para alteração
    
    public ActionResult<List<Estrela>> Listar()
    {
        //Início do trecho para alteração
         return _estrelaService.Listar();
        //Fim do trecho para alteração
    }

    //Início do trecho para alteração
    [HttpGet("{codigo}")]
    //Fim do trecho para alteração
    public ActionResult<Estrela> Pesquisar(int codigo)
    {
        //Início do trecho para alteração
        var estrela = _estrelaService.Pesquisar(codigo);
        
        if (estrela is null)
        {
            return NotFound();
        }
        return estrela;
        //Fim do trecho para alteração
    }

    //Início do trecho para alteração
    [HttpPost]
    //Fim do trecho para alteração
    public ActionResult Incluir([FromBody] Estrela estrela)
    {
        //Início do trecho para alteração    
         _estrelaService.Incluir(estrela.Codigo, estrela.Nome);
        return CreatedAtAction(nameof(Incluir), new { id = estrela.Codigo}, estrela);
        //Fim do trecho para alteração        
    }

}
