using FastEndpoints;
using FastEndpointsSample.ApplicationCore.Services;
using FastEndpointsSample.ApplicationCore.Mappers;
using FastEndpointsSample.ApplicationCore.Models.Response;

namespace MyEndpointProject.Endpoints;

public class EmployeeEndpoint(IEmployeeService employeeService) : EndpointWithoutRequest<GetEmployeeResponse, EmployeeMapper>
{
    public override void Configure()
    {
        Get("/api/Employees/{id}");
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
        await SendAsync(response);
    }
}  
