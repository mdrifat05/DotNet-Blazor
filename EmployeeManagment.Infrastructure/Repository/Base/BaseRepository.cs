using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Infrastructure.Repository.Base;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    readonly ApplicationDbContext _db;
    public BaseRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public DbSet<T> Table
    {
        get { return _db.Set<T>(); }
    }

    public async Task<bool> Create(T entity, CancellationToken cancellationToken = default)
    {
        Table.Add(entity);
        return await _db.SaveChangesAsync(cancellationToken) > 0;
    }

    public async Task<bool> Delete(T entity, CancellationToken cancellationToken = default)
    {
        Table.Remove(entity);
        return await _db.SaveChangesAsync(cancellationToken) > 0;
    }

    public async Task<IReadOnlyList<T>> GetAll(CancellationToken cancellationToken = default)
    {
        return await Table.ToListAsync(cancellationToken);
    }

    public async Task<bool> Update(T entity, CancellationToken cancellationToken = default)
    {
        Table.Update(entity);
        return await _db.SaveChangesAsync(cancellationToken) > 0;
    }
}
