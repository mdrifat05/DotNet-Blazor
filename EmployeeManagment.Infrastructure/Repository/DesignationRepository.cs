using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Domain.Entities.Designations;
using EmployeeManagment.Infrastructure.Context;
using EmployeeManagment.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Infrastructure.Repository;

public class DesignationRepository : BaseRepository<Designation>, IDesignationRepository
{
    readonly ApplicationDbContext _db;
    public DesignationRepository(ApplicationDbContext db): base(db)
    {
        _db = db;
    }
    public async Task<Designation> GetById(int id, CancellationToken cancellationToken)
    {
        return await _db.Designations.FirstOrDefaultAsync(d=> d.Id==id, cancellationToken);
    }
}
