using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using Semana11.Models;

namespace Semana11.Services
{
    public class EstrelaService
    {        
        readonly HttpClient _httpClient;

        public EstrelaService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5204/Estrelas");
        }

        public List<Estrela> Listar()
        {            
            //Início do trecho para alteração
            var response = _httpClient.????; 
            //Fim do trecho para alteração

            if (response == null)           
                throw new Exception("Impossível consultar Estrelas");

            return response;            
        }

        public Estrela? Pesquisar(int codigo)
        {
            //Início do trecho para alteração
            var response = _httpClient.??????;
            //Fim do trecho para alteração

            return response;            
        }

        public void Incluir(Estrela estrela)
        {        
            //Início do trecho para alteração    
            var result = _httpClient.??????;
            //Fim do trecho para alteração

            result.EnsureSuccessStatusCode();            
        }
        
    }
}