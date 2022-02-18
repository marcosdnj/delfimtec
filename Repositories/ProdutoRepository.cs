using DelfimTec.Context;
using DelfimTec.Models;
using DelfimTec.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DelfimTec.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }







        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Categoria);

        public IEnumerable<Produto> ProdutosPreferido => _context.Produtos.Where(l => l.IsProdutoPreferido).Include(c => c.Categoria);

        public Produto GetProdutoById(int produtoid)
        {
            return _context.Produtos.FirstOrDefault(l => l.ProdutoId == produtoid);
        }
    }
}
