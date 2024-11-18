using DDDWebAPI.Domain.Core.Interfaces.Repositories;
using DDDWebAPI.Domain.Core.Interfaces.Services;

namespace DDDWebAPI.Domain.Services.Services
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        protected ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void add(TEntity obj)
        {
           _repository.add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);    
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
