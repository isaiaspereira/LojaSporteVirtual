using LojaSporteVirtual.Application.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LojaEsporeVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {

        private readonly IProdutoApplication _produtoApplication;


        public CategoriaController(IProdutoApplication produto)
        {
            _produtoApplication = produto;
        }
        // GET: Categoria
        public PartialViewResult Menu(string categoria = null)
        {

            ViewBag.CategoriaSelecionada = categoria;

            IEnumerable<string> Categorias = _produtoApplication.GetAll()
                .Select(c => c.Categoria.NomeCategoria)
                .Distinct()
                .OrderBy(c => c);
            return PartialView(Categorias);
        }
    }
}