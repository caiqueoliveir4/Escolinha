using System.Collections.Generic;
using System.Linq;
using WebApi01.Models;

namespace WebApi01.Services
{
    public class EstrelaService
    {
        readonly EstrelasContext _estrelasContext;

        public EstrelaService(EstrelasContext estrelasContext)
        {
            _estrelasContext = estrelasContext;
        }

        public List<Estrela> Listar()
        {
            return _estrelasContext.Estrelas.ToList();            
        }

        public Estrela? Pesquisar(int codigo)
        {
            return _estrelasContext.Estrelas.Where(s => s.Codigo == codigo).FirstOrDefault();
        }

        public void Incluir(int codigo, string nome)
        {
            var estrela = new Estrela { Codigo = codigo, Nome = nome };

            _estrelasContext.Estrelas.Add(estrela);
            _estrelasContext.SaveChanges();
        }
        
    }
}