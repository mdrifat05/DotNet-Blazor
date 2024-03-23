using EmployeeManagment.Domain.Entities.Departments;
using EmployeeManagment.Domain.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Domain.Abstraction;

public interface IDepartmentRepository : IRepository<Department>
{
    Task<Department> GetById(int id, CancellationToken cancellationToken);

}
