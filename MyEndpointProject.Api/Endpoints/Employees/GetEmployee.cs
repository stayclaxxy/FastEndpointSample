using FastEndpoints;
using MyEndpointProject.ApplicationCore.Services;
using MyEndpointProject.ApplicationCore.Mappers;
using MyEndpointProject.ApplicationCore.Models.Response;

namespace MyEndpointProject.Endpoints.Employees;

public class GetEmployee(IEmployeeService employeeService) : EndpointWithoutRequest<GetEmployeeResponse, EmployeeMapper>
{
    public override void Configure()
    {
        Get("/employee/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var id = Route<int>("id");
        
        var response = Map.FromEntity(await employeeService.GetEmployee(id));
        if (response is null)
        {
            await SendNotFoundAsync(ct);
            return;
        }
        await SendOkAsync(response, ct);
    }
}