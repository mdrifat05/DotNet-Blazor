using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Domain.Entities.Employees;
using EmployeeManagment.Domain.Enums;

namespace EmployeeManagment.Domain.Entities.Departments;

public sealed class Department
{
    public Guid Id { get; set; }
    public DepartmentType Name { get; set; } // Change type to DepartmentType
    public string Location { get; set; }
}
