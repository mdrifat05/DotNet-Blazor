using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Domain.Enums;

namespace EmployeeManagment.Domain.Entities.Designations;

public sealed class Designation 
{

    public Guid Id { get; set; }
    public DesignationType Title { get; set; } // Change type to DesignationType
    public string Description { get; set; }
}
