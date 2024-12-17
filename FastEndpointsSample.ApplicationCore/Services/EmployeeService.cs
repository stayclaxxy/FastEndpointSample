using FastEndpointsSample.Infrastructure.Data;
using FastEndpointsSample.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastEndpointsSample.ApplicationCore.Services;

public class EmployeeService(AdventureWorksContext dbContext) : IEmployeeService
{
    public async Task<Employee?> GetEmployee(int employeeId)
    {
        return await dbContext.Employees.FindAsync(employeeId);
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        return await dbContext.Employees.ToListAsync();
    }
}