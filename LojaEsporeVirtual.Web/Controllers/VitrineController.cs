using LojaEsporeVirtual.Web.Helps;
using LojaEsporeVirtual.Web.Models;
using LojaSporteVirtual.Application.Interface;
using System.Linq;
using System.Web.Mvc;

namespace LojaEsporeVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private readonly IProdutoApplication _repository;

        public VitrineController(IProdutoApplication produto)
        {
            _repository = produto;
        }

        public ViewResult ListaProduto(string categoria, int Pagina = 1)
        {
            int ProdutoPorPagina = 3;

            ProdutosViewModel model = new ProdutosViewModel
            {
                Produtos = _repository.GetAll()
                .Where(p => categoria == null || p.Categoria.NomeCategoria == categoria.ToUpper())
                .OrderBy(o => o.Nome)
                .Skip((Pagina - 1) * ProdutoPorPagina)
                .Take(ProdutoPorPagina),

                Paginacao = new Paginacao
                {
                    PaginaAtual = Pagina,
                    ItensPorPagina = ProdutoPorPagina,
                    ItensTotal = _repository.GetAll().Count()
                },
                CategoriaAtual = categoria
            };

            return View(model);
        }
    }
}