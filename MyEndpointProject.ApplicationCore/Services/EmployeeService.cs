using Microsoft.EntityFrameworkCore;
using MyEndpointProject.Infrastructure.Data;
using MyEndpointProject.Infrastructure.Entities;

namespace MyEndpointProject.ApplicationCore.Services;

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
    
    public async Task<IEnumerable<Employee>> GetEmployees(int skip, int take)
    {
        return await dbContext.Employees.Skip(skip).Take(take).ToListAsync();
    }
}