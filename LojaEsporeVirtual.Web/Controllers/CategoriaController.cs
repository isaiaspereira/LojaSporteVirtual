using LojaSporteVirtual.Repositorie.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaEsporeVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {

        private readonly ProdutoRepository repository = new ProdutoRepository();
        // GET: Categoria
        public PartialViewResult Menu(string categoria = null)
        {

            ViewBag.CategoriaSelecionada = categoria;

            IEnumerable<string> Categorias = repository.GetAll()
                .Select(c => c.Categoria.NomeCategoria)
                .Distinct()
                .OrderBy(c => c);
            return PartialView(Categorias);
        }
    }
}