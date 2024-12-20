using MyEndpointProject.Infrastructure.Entities;

namespace MyEndpointProject.ApplicationCore.Services;

public interface IEmployeeService
{
    public Task<Employee?> GetEmployee(int employeeId);
    public Task<IEnumerable<Employee>> GetEmployees();
    public Task<IEnumerable<Employee>> GetEmployees(int skip, int take);
}