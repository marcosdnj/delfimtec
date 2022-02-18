using DelfimTec.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DelfimTec.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult List()
        {


            var produtos = _produtoRepository.Produtos;
            return View();

        }
    }
}
