using LojaSporteVirtual.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LojaSporteVirtual.Repositorie.Repository
{

    public class RepositoryBase<TEntity> :  IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly StrLojaVirtual db = new StrLojaVirtual();
        public void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int Id)
        {
            return db.Set<TEntity>().Find(Id);
        }


        public void Update(TEntity obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }
    }
}
