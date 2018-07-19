using LojaSporteVirtual.Domain.Interface.Repository;
using LojaSporteVirtual.Domain.Interface.Service;
using System.Collections.Generic;

namespace LojaSporteVirtual.Domain.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repository = repositoryBase;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Commit()
        {
            _repository.Commit();
        }

        public void Delete(TEntity obj)
        {
            _repository.Delete(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int Id)
        {
            return _repository.GetById(Id);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
    }
}
