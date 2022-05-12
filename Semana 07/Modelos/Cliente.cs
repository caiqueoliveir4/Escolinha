using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EF01.Modelos
{
    public class Cliente
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }                
        public virtual List<NotaFiscal> NotasFiscais { get; set; }
    }
}