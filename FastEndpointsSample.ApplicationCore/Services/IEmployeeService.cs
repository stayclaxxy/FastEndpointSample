using FastEndpointsSample.Infrastructure.Entities;

namespace FastEndpointsSample.ApplicationCore.Services;

public interface IEmployeeService
{
    public Task<Employee?> GetEmployee(int employeeId);
    public Task<IEnumerable<Employee>> GetEmployees();
}