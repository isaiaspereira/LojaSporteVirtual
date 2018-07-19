using System.Collections.Generic;

namespace LojaSporteVirtual.Domain.Interface.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        void Add(TEntity obj);
        TEntity GetById(int Id);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Commit();
    }
}
