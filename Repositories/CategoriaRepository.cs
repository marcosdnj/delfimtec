using DelfimTec.Context;
using DelfimTec.Models;
using DelfimTec.Repositories.Interfaces;

namespace DelfimTec.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
  
    
    
    
    
    
    
    
    
    
    }
}
