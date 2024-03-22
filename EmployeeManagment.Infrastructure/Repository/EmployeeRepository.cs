using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Domain.Entities.Employees;
using EmployeeManagment.Infrastructure.Context;
using EmployeeManagment.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Infrastructure.Repository;

public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
{
    readonly ApplicationDbContext _db;

    public EmployeeRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<Employee> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await _db.Employees.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }
}
