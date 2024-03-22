using EmployeeManagment.Domain.Entities.Departments;

namespace EmployeeManagment.Application.Abstraction;

public interface IDepartmentService : IService<Department>
{
    Task<Department> GetById(Guid id, CancellationToken cancellationToken = default);
}
