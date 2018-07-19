using LojaSporteVirtual.Application.Interface;
using LojaSporteVirtual.Domain.Entity;
using LojaSporteVirtual.Domain.Interface.Service;

namespace LojaSporteVirtual.Application.Service
{
    public class ProdutoApplication:ApplicationBase<Produto>,IProdutoApplication
    {

        private readonly IProdudoService _produdoService;

        public ProdutoApplication(IProdudoService produdo):base(produdo)
        {
            _produdoService = produdo;
        }
    }
}
