using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EF01.Modelos
{
    public class ContextoExemplo : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("exemplo");
        }

        //Início do trecho para alteração
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<NotaFiscal> NotasFiscais { get; set; }
        //Fim do trecho para alteração

    }
}