using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Domain.Enums;
using EmployeeManagment.Domain.Entities.Departments;
using EmployeeManagment.Domain.Entities.Designations;
namespace EmployeeManagment.Domain.Entities.Employees;

public sealed class Employee 
{
    public  int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }
    public int Salary { get; set; }
    public DateTime CreatedOn { get; init; }
    public DateTime UpdatedOn { get; set; }

    // Navigation Properties
    public int DesignationId { get; set; }
    public Designation Designation { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; }
   
}
