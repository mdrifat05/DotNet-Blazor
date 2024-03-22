using EmployeeManagment.Domain.Entities.Employees;

namespace EmployeeManagment.Application.Abstraction;

public interface IEmployeeService : IService<Employee>
{
    Task<Employee> GetById(Guid id, CancellationToken cancellationToken = default);
}
