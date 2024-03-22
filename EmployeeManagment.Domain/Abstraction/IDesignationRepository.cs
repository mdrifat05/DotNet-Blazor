using EmployeeManagment.Domain.Entities.Departments;
using EmployeeManagment.Domain.Entities.Designations;
using EmployeeManagment.Domain.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Domain.Abstraction;

public interface IDesignationRepository : IRepository<Designation>
{
    Task<Designation> GetById(Guid id, CancellationToken cancellationToken);

}
