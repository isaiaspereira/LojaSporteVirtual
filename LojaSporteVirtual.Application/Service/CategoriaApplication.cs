using LojaSporteVirtual.Application.Interface;
using LojaSporteVirtual.Domain.Entity;
using LojaSporteVirtual.Domain.Interface.Service;

namespace LojaSporteVirtual.Application.Service
{
    public class CategoriaApplication:ApplicationBase<Categoria>,ICategoriaApplication
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaApplication(ICategoriaService categoria):base(categoria)
        {
            _categoriaService = categoria;
        }
    }
}
