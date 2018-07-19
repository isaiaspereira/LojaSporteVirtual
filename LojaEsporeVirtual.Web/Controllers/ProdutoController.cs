using LojaSporteVirtual.Domain.Entity.Interface;
using LojaSporteVirtual.Repositorie.Repository;
using System.Web.Mvc;

namespace LojaEsporeVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository repository;
        public ProdutoController(IProdutoRepository produto)
        {
            repository = produto;
        }

        // GET: Produto
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

    }
}
