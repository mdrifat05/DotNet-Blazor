using EmployeeManagment.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Application.Dtos;

public record CreateEmployeeCommand( 
    Guid EmployeeId, 
    string FirstName, 
    string LastName,
    DateTime HireDate,
    int Salary,
    DesignationType DesignationId,
    DepartmentType DepartmentId
    );
