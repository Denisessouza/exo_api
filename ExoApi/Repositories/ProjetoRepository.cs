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
    }
}
