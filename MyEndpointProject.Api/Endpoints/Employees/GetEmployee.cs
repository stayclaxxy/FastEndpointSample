using FastEndpoints;
using MyEndpointProject.ApplicationCore.Services;
using MyEndpointProject.ApplicationCore.Mappers;
using MyEndpointProject.ApplicationCore.Models.Response;

namespace MyEndpointProject.Endpoints.Employees;

public class GetEmployee(IEmployeeService employeeService) : EndpointWithoutRequest<GetEmployeeResponse, EmployeeMapper>
{
    public override void Configure()
    {
        Get("/employees/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var id = Route<int>("id");
        
        var employee = await employeeService.GetEmployee(id);
        if (employee is null)
        {
            await SendNotFoundAsync(ct);
            return;
        }
        await SendMappedAsync(employee, 200, ct);
    }
}