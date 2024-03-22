using EmployeeManagment.Application.Abstraction;
using EmployeeManagment.Application.Services.Base;
using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Domain.Entities.Employees;

public class EmployeeService :BaseService<Employee>, IEmployeeService
{
    readonly IEmployeeRepository _employeeRepository;
    public EmployeeService(IEmployeeRepository employeeRepository) : base(employeeRepository)
    {
            _employeeRepository = employeeRepository;    
    }

    public async Task<Employee> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await _employeeRepository.GetById(id, cancellationToken);
    }
    public override async Task<bool> Update(Employee entity, CancellationToken cancellationToken = default)
    {
        // You can add custom logic here before or after calling the base method
        // For example:
        entity.UpdatedOn = DateTime.UtcNow;

        // Call the base Update method
        return await base.Update(entity, cancellationToken);
    }

}