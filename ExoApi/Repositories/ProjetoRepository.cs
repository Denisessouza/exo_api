using ExoApi.Contexts;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly dbExoApiContext _context;

        public ProjetoRepository(dbExoApiContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projeto BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Atualizar(Projeto projeto, int id)
        {
            Projeto projetoBuscado = _context.Projetos.Find(id);
            if (projetoBuscado != null)
            {
                projetoBuscado.Titulo = projeto.Titulo;
                projetoBuscado.Status = projeto.Status;
                projetoBuscado.Data_Inicio = projeto.Data_Inicio;
                projetoBuscado.Area = projeto.Area;
            }
            _context.Projetos.Update(projetoBuscado);
            _context.SaveChanges();
        }

    

    
    
    }
}
