using System;
using System.Linq;
using System.Collections.Generic;

namespace ExemploLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            Console.WriteLine("1. Fornecedores ordenados por Nome");

            //Início o trecho para alteração
            var fornecedoresOrdenados = Fornecedor.Lista.OrderBy(z => z.Nome);
            //Fim do trecho para alteração

            foreach(var fornecedor in fornecedoresOrdenados)
                Console.WriteLine("- Codigo: {0} Nome: '{1}'", fornecedor.Codigo, fornecedor.Nome);



            Console.WriteLine();
            Console.WriteLine("2. Notas Fiscais do fornecedor 2");

            //Início o trecho para alteração            
            var notasFiscaisFornecedor2 = NotaFiscal.Lista.Where(z => z.CodigoFornecedor == 2);
            //Fim do trecho para alteração

            foreach(var notaFiscal in notasFiscaisFornecedor2)
                Console.WriteLine("- Número: {0} Valor Total: {1:C}", notaFiscal.Numero, notaFiscal.ValorTotal);



            Console.WriteLine();
            Console.WriteLine("3. Valor total das notas por fornecedor");

            //Início do trecho para alteração
            var valorTotalNotasPorFornecedor = NotaFiscal.Lista.
             Join(Fornecedor.Lista,
             nota => nota.CodigoFornecedor,
             frn => frn.Codigo,
             (nota, frn) => new {frn.Nome, nota.ValorTotal});
            //Fim do trecho para alteração

            foreach(var item in valorTotalNotasPorFornecedor)
                Console.WriteLine("- Fornecedor: '{0}' Valor Total: {1:C}", item.Fornecedor, item.Valor);
            
        }

    }

    public class Fornecedor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Fornecedor(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public static IEnumerable<Fornecedor> Lista = new List<Fornecedor>() 
        {
            new Fornecedor(1, "Casa dos pregos"),
            new Fornecedor(2, "Tintas Marta"),
            new Fornecedor(3, "Supermercado Baratão")
        };        
    }

    public class NotaFiscal
    {
        public int Numero { get; set; }        
        public int CodigoFornecedor { get; set; }
        public double ValorTotal { get; set; }

        public static IEnumerable<NotaFiscal> Lista = new List<NotaFiscal>()
        {
            new NotaFiscal(1001, 1, 50),
            new NotaFiscal(1002, 1, 65.5),
            new NotaFiscal(1003, 2, 1428),
            new NotaFiscal(1004, 3, 99.99),
            new NotaFiscal(1005, 3, 67.8),
            new NotaFiscal(1006, 3, 9.99)
        };

        public NotaFiscal(int numero, int codigoFornecedor, double valorTotal)
        {
            Numero = numero;
            CodigoFornecedor = codigoFornecedor;
            ValorTotal = valorTotal;
        }

    }

}