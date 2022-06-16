using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Semana11.Models;


namespace Semana11.Services
{
    public class SistemaService
    {
        readonly HttpClient _httpClient;

        public SistemaService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5204/Sistemas");
        }

        public List<Sistema> Listar()
    
        {            
            //Início do trecho para alteração
            var response =  _httpClient.GetByteArrayAsync("http://localhost:5204/Sistemas");
            response.Wait();
            //Fim do trecho para alteração

            if (response == null)           
                throw new Exception("Impossível consultar Sistemas");

            return response;            
        }

        public  async Sistema? Pesquisar(int codigo)
        {
            //Início do trecho para alteração
            var response =  await _httpClient.GetAsync("Sistemas");
            //Fim do trecho para alteração

            return response;            
        }

        public void Incluir(int codigo, string nome)
        {
            //Início do trecho para alteração 
             var sistema = new Sistema() {Codigo = codigo , Nome = nome};          
            var result = _httpClient.PostAsJsonAsync<Sistema>("http://localhost:5204/Sistemas", sistema );
            //Fim do trecho para alteração

             result.EnsureSuccessStatusCode();            
        }
        
    }
}