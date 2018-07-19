using System.Collections.Generic;
using LojaSporteVirtual.Application.Interface;
using LojaSporteVirtual.Domain.Interface.Service;

namespace LojaSporteVirtual.Application.Service
{
    public class ApplicationBase<TEntity> : IApplicationBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _service;

        public ApplicationBase(IServiceBase<TEntity> serviceBase)
        {
            _service = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _service.Add(obj);
        }

        public void Commit()
        {
            _service.Commit();
        }

        public void Delete(TEntity obj)
        {
            _service.Delete(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public TEntity GetById(int Id)
        {
            return _service.GetById(Id);
        }

        public void Update(TEntity obj)
        {
            _service.Update(obj);
        }
    }
}
