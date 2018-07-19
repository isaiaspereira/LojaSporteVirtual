using LojaSporteVirtual.Domain.Entity;
using LojaSporteVirtual.Domain.Interface.Repository;
using LojaSporteVirtual.Domain.Interface.Service;

namespace LojaSporteVirtual.Domain.Service
{
    public class CategoriaService:ServiceBase<Categoria>,ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoria):base(categoria)
        {
            _categoriaRepository = categoria;
        }
    }
}
