using System;
using System.Collections.Generic;
using System.Linq;
using Semana11.Models;
using Semana11.Services;

namespace Semana11
{
    public class Program
    {
        static SistemaService _sistemaService = new SistemaService();
        static EstrelaService _estrelaService = new EstrelaService();
        static List<Sistema>? _sistemas;
        static List<Estrela>? _estrelas;

        public static void Main(string[] args)
        {            
            ListarSistemas();
            AdicionarSistemas();
            ListarSistemas();

            ListarEstrelas();
            AdicionarEstrelas();
            ListarEstrelas();
        }

        public static void ListarSistemas()
        {
            Console.WriteLine("> Listando Sistemas");

            _sistemas = _sistemaService.Listar();

            if (_sistemas.Count < 1)
            {
                Console.WriteLine("Nenhum sistema cadastrado");
                return;
            }

            foreach(var sistema in _sistemas)
                Console.WriteLine($"- Código: {sistema.Codigo} Nome: {sistema.Nome}");

        }

        public static void AdicionarSistemas()
        {

            if (_sistemas?.Count > 0) 
            {
                Console.WriteLine("Sistemas já adicionados");
                return;
            }


            Console.WriteLine("> Adicionando Sistemas");

            _sistemaService.Incluir(1, "Sistema Solar");
            _sistemaService.Incluir(2, "Alpha Centauri");
            _sistemaService.Incluir(3, "Sirius");
        }

        public static void ListarEstrelas()
        {
            Console.WriteLine("> Listando Estrelas");

            _estrelas = _estrelaService.Listar();

            if (_estrelas.Count < 1)
            {
                Console.WriteLine("Nenhuma estrela cadastrada");
                return;
            }

            foreach(var estrela in _estrelas)
                Console.WriteLine($"- Código: {estrela.Codigo} Nome: '{estrela.Nome}' Sistema: '{_sistemas?.FirstOrDefault(s => s.Codigo == estrela.SistemaCodigo)?.Nome}' Classificação: {estrela.Classificacao} Magnitude Absoluta: {estrela.MagnitudeAbsoluta} Distância: {estrela.Distancia} anos-luz");

        }

        public static void AdicionarEstrelas()
        {

            if (_estrelas?.Count > 0)
            {
                Console.WriteLine("Estrelas já adicionadas");
                return;
            }

            Console.WriteLine("> Adicionando Estrelas");

            _estrelaService.Incluir(new Estrela {
                Codigo = 1, 
                Nome = "Sol",
                SistemaCodigo = 1,
                Classificacao = "G2V",
                MagnitudeAbsoluta = (decimal)4.85,
                Distancia = 0                            
            });

            _estrelaService.Incluir(new Estrela {
                Codigo = 2, 
                Nome = "Proxima Centauri",
                SistemaCodigo = 2,
                Classificacao = "M5.5Ve",
                MagnitudeAbsoluta = (decimal)15.53,
                Distancia = (decimal)4.2421
            });

            _estrelaService.Incluir(new Estrela {
                Codigo = 3, 
                Nome = "α Centauri A",
                SistemaCodigo = 2,
                Classificacao = "G2V",
                MagnitudeAbsoluta = (decimal)4.38,
                Distancia = (decimal)4.3650
            });

            _estrelaService.Incluir(new Estrela {
                Codigo = 4, 
                Nome = "α Centauri B",
                SistemaCodigo = 2,
                Classificacao = "K1V",
                MagnitudeAbsoluta = (decimal)5.71,
                Distancia = (decimal)4.3650
            });

            _estrelaService.Incluir(new Estrela {
                Codigo = 5, 
                Nome = "Sirius A",
                SistemaCodigo = 3,
                Classificacao = "A1V",
                MagnitudeAbsoluta = (decimal)1.42,
                Distancia = (decimal)8.5828
            });

            _estrelaService.Incluir(new Estrela {
                Codigo = 6, 
                Nome = "Sirius B",
                SistemaCodigo = 3,
                Classificacao = "DA2",
                MagnitudeAbsoluta = (decimal)11.34,
                Distancia = (decimal)8.5828
            });
        }
    }
}