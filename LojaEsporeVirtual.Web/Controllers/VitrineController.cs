using LojaEsporeVirtual.Web.Helps;
using LojaEsporeVirtual.Web.Models;
using LojaSporteVirtual.Repositorie.Repository;
using System.Linq;
using System.Web.Mvc;

namespace LojaEsporeVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        public ViewResult ListaProduto(string categoria, int Pagina = 1)
        {
            int ProdutoPorPagina = 3;
            var produtoRepository = new ProdutoRepository();
            //var listaCategoria = produtoRepository.GetAll().Where(c=>c.Categoria.NomeCategoria.Equals("Futebol"));
            ProdutosViewModel model = new ProdutosViewModel
            {
                Produtos = produtoRepository.GetAll()
                .Where(p => categoria == null || p.Categoria.NomeCategoria == categoria.ToUpper())
                .OrderBy(o => o.Nome)
                .Skip((Pagina - 1) * ProdutoPorPagina)
                .Take(ProdutoPorPagina),

                Paginacao = new Paginacao
                {
                    PaginaAtual = Pagina,
                    ItensPorPagina = ProdutoPorPagina,
                    ItensTotal = produtoRepository.GetAll().Count()
                },
                CategoriaAtual = categoria
            };

            return View(model);
        }
    }
}