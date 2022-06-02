using System.Collections.Generic;
using System.Linq;
using WebApi01.Models;

namespace WebApi01.Services
{
    public class SistemaService
    {
        readonly EstrelasContext _estrelasContext;

        public SistemaService(EstrelasContext estrelasContext)
        {
            _estrelasContext = estrelasContext;
        }

        public List<Sistema> Listar()
        {
            return _estrelasContext.Sistemas.ToList();            
        }

        public Sistema? Pesquisar(int codigo)
        {
            return _estrelasContext.Sistemas.Where(s => s.Codigo == codigo).FirstOrDefault();
        }

        public void Incluir(int codigo, string nome)
        {
            var sistema = new Sistema { Codigo = codigo, Nome = nome };

            _estrelasContext.Sistemas.Add(sistema);
            _estrelasContext.SaveChanges();
        }
        
    }
}