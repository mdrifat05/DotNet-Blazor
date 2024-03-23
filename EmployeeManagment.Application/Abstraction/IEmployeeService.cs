using EmployeeManagment.Domain.Entities.Employees;

namespace EmployeeManagment.Application.Abstraction;

public interface IEmployeeService : IService<Employee>
{
    Task<Employee> GetById(int id, CancellationToken cancellationToken = default);
}
