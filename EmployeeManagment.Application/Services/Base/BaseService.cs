using EmployeeManagment.Application.Abstraction;
using EmployeeManagment.Domain.Abstraction;

namespace EmployeeManagment.Application.Services.Base
{
    public class BaseService<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<bool> Add(T entity, CancellationToken cancellationToken = default)
        {
            return await _repository.Create(entity, cancellationToken);
        }

        public virtual async Task<bool> Delete(T entity, CancellationToken cancellationToken = default)
        {
            return await _repository.Delete(entity, cancellationToken);
        }

        public virtual async Task<IReadOnlyList<T>> GetAll(CancellationToken cancellationToken = default)
        {
            return await _repository.GetAll(cancellationToken);
        }

        public virtual async Task<bool> Update(T entity, CancellationToken cancellationToken = default)
        {
            return await _repository.Update(entity, cancellationToken);
        }
    }
}
