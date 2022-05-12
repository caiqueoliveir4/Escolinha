using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF01.Modelos
{
    public class NotaFiscal
    {
        [Key]
        public int Numero { get; set; }
        public double Valor { get; set; }
        public int CodigoCliente { get; set; }

        [ForeignKey("CodigoCliente")]
        public virtual Cliente Cliente { get; set; }
    }
}