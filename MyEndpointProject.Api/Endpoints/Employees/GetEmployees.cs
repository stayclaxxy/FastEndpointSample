using FastEndpoints;
using MyEndpointProject.ApplicationCore.Mappers;
using MyEndpointProject.ApplicationCore.Models.Request;
using MyEndpointProject.ApplicationCore.Services;
using MyEndpointProject.ApplicationCore.Models.Response;
using MyEndpointProject.Infrastructure.Entities;

namespace MyEndpointProject.Endpoints.Employees;

public class GetEmployees(IEmployeeService employeeService) : Endpoint<BaseRequest, List<GetEmployeeResponse>, EmployeeMapper>
{
    public override void Configure()
    {
        Get("/employees");
        AllowAnonymous();
    }

    public override async Task HandleAsync(BaseRequest r, CancellationToken ct)
    {
        IEnumerable<Employee> employees;
        if (r is { Skip: not null, Take: not null })
        {
            employees = await employeeService.GetEmployees(r.Skip.Value, r.Take.Value);
        }
        else
        {
            employees = await employeeService.GetEmployees();
        }
        var response = employees.Select(e => Map.FromEntity(e)!).ToList();
        await SendOkAsync(response, ct);
    }
}  
