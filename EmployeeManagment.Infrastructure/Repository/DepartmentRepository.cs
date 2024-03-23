using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Domain.Entities.Departments;
using EmployeeManagment.Infrastructure.Context;
using EmployeeManagment.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Infrastructure.Repository;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
    readonly ApplicationDbContext _db;
    public DepartmentRepository(ApplicationDbContext db): base(db)
    {
        _db = db;
    }
    public async Task<Department> GetById(int id, CancellationToken cancellationToken)
    {
        return await _db.Departments.FirstOrDefaultAsync(d => d.Id == id, cancellationToken);
    }
}
