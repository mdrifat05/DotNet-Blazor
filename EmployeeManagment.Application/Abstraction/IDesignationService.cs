using EmployeeManagment.Domain.Entities.Departments;
using EmployeeManagment.Domain.Entities.Designations;

namespace EmployeeManagment.Application.Abstraction;

public interface IDesignationService : IService<Designation>
{
    Task<Designation> GetById(int id, CancellationToken cancellationToken = default);

}
