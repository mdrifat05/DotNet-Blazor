namespace EmployeeManagment.Domain.Abstraction
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAll(CancellationToken cancellationToken = default);
        Task<bool> Create(T entity, CancellationToken cancellationToken = default);
        Task<bool> Update(T entity, CancellationToken cancellationToken = default);
        Task<bool> Delete(T entity, CancellationToken cancellationToken = default);
    }
}
