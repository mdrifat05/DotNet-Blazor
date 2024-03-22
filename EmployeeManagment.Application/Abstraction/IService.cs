using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagment.Application.Abstraction
{
    public interface IService<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAll(CancellationToken cancellationToken = default);
        Task<bool> Add(T entity, CancellationToken cancellationToken = default);
        Task<bool> Delete(T entity, CancellationToken cancellationToken = default);
        Task<bool> Update(T entity, CancellationToken cancellationToken = default);
    }
}
