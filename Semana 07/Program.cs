
using System.IO.Compression;
using System.Collections.Generic;
using System;
using System.Linq;
using EF01.Modelos;

namespace EF01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var ctx = new ContextoExemplo();

            AdicionarClientes(ctx);
            AdicionarNotasFiscais(ctx);

            ListarClientes(ctx);
            ListarNotasFiscais(ctx, 1);
        }

        static void AdicionarClientes(ContextoExemplo contexto)
        {
            var cliente1 = new Cliente { Codigo = 1, Nome = "Rodrigo" };
            var cliente2 = new Cliente { Codigo = 2, Nome = "Eduardo" };
            var cliente3 = new Cliente { Codigo = 3, Nome = "Maria" };

            //Início do trecho para alteração
           
            contexto.Clientes.AddRange(cliente1, cliente2, cliente3);
            contexto.SaveChanges();
            //Fim do trecho para alteração
        }

        static void ListarClientes(ContextoExemplo contexto)
        {
            //Início do trecho para alteração
            var clientes = contexto.Clientes.ToList();
            //Fim do trecho para alteração

            Console.WriteLine("-- Clientes --");

            foreach (var cliente in clientes)
                Console.WriteLine($"Código: {cliente.Codigo} Nome: '{cliente.Nome}' Notas Fiscais: {cliente.NotasFiscais?.Count()}");

        }

        static void AdicionarNotasFiscais(ContextoExemplo contexto)
        {
            var nf1000 = new NotaFiscal { Numero = 1000, Valor = 99.99, CodigoCliente = 1 };
            var nf1001 = new NotaFiscal { Numero = 1001, Valor = 105, CodigoCliente = 1 };
            var nf1002 = new NotaFiscal { Numero = 1002, Valor = 50, CodigoCliente = 2 };

            // Início do trecho para alteração
            
            contexto.NotasFiscais.AddRange(nf1000, nf1001, nf1002);
            contexto.SaveChanges();
            // Fim do trecho para alteração
        }

        static void ListarNotasFiscais(ContextoExemplo contexto, int codigoCliente)
        {
            // Início do trecho para alteração
            var notasFiscais = contexto.NotasFiscais.Where(n => n.Cliente.Codigo == codigoCliente).ToList();
            // //Fim do trecho para alteração

            Console.WriteLine($"-- Notas Fiscais do Cliente {codigoCliente} --");

            foreach (var notaFiscal in notasFiscais)
                Console.WriteLine($"Número: {notaFiscal.Numero} Valor: {notaFiscal.Valor} Cliente: '{notaFiscal.Cliente.Nome}'");

        }
    }
}