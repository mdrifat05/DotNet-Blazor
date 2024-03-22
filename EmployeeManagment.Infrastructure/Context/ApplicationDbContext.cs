using EmployeeManagment.Domain.Entities.Departments;
using EmployeeManagment.Domain.Entities.Designations;
using EmployeeManagment.Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Designation> Designations { get; set; }
    public DbSet<Department> Departments { get; set; }
}
