using System.ComponentModel.DataAnnotations;

namespace WebApi01.Models
{
    public class Sistema
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
}