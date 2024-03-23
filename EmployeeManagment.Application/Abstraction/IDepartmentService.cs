using EmployeeManagment.Domain.Entities.Departments;

namespace EmployeeManagment.Application.Abstraction;

public interface IDepartmentService : IService<Department>
{
    Task<Department> GetById(int id, CancellationToken cancellationToken = default);
}
