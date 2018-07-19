using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSporteVirtual.Domain.Entity.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        void Add(TEntity obj);
        TEntity GetById(int Id);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();
        void Commit();
    }
}
