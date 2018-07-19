using System.Collections.Generic;

namespace LojaSporteVirtual.Domain.Interface.Service
{
    public interface IServiceBase<TEntity> where TEntity :class
    {
        IEnumerable<TEntity> GetAll();
        void Add(TEntity obj);
        TEntity GetById(int Id);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Commit();
    }
}
