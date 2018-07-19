using LojaSporteVirtual.Application.Interface;
using LojaSporteVirtual.Domain.Interface.Repository;
using System.Web.Mvc;

namespace LojaEsporeVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoApplication repository;
        public ProdutoController(IProdutoApplication produto)
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
