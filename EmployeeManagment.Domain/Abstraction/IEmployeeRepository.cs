using EmployeeManagment.Domain.Entities.Employees;

namespace EmployeeManagment.Domain.Abstraction
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<Employee> GetById(int id, CancellationToken cancellationToken);
    }
}
