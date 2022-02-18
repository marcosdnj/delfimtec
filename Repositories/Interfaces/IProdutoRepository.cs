using DelfimTec.Models;

namespace DelfimTec.Repositories.Interfaces
{
    public interface IProdutoRepository
    {

        IEnumerable<Produto> Produtos { get; }

        IEnumerable<Produto> ProdutosPreferido { get; }

        Produto GetProdutoById(int produtoid);




    }
}
