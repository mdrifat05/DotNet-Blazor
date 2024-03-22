using EmployeeManagment.Application.Abstraction;
using EmployeeManagment.Application.Services.Departments;
using EmployeeManagment.Application.Services.Designations;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagment.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IDepartmentService, DepartmentService>();
        services.AddScoped<IDesignationService, DesignationService>();

        return services;
    }
}
