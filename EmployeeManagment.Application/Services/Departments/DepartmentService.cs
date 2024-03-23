using EmployeeManagment.Application.Abstraction;
using EmployeeManagment.Application.Services.Base;
using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Domain.Entities.Departments;

namespace EmployeeManagment.Application.Services.Departments;

public class DepartmentService : BaseService<Department>, IDepartmentService
{
    readonly IDepartmentRepository _departmentsRepository;
    public DepartmentService(IDepartmentRepository departmentRepository) : base(departmentRepository)
    {
        _departmentsRepository = departmentRepository;
    }
    public async Task<Department> GetById(int id, CancellationToken cancellationToken = default)
    {
        return await _departmentsRepository.GetById(id, cancellationToken); 
    }
}
