using LojaSporteVirtual.Domain.Entity;
using LojaSporteVirtual.Domain.Interface.Repository;
using LojaSporteVirtual.Domain.Interface.Service;

namespace LojaSporteVirtual.Domain.Service
{
    public class ProdutoService:ServiceBase<Produto>,IProdudoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produto):base(produto)
        {
            _produtoRepository = produto;
        }
    }
}
