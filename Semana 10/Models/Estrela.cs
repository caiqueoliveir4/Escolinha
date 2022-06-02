using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi01.Models
{
    public class Estrela
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int SistemaCodigo { get; set; }
        public string Classificacao { get; set; }
        public decimal MagnitudeAbsoluta { get; set; }
        public decimal Distancia { get; set; }        
    }
}