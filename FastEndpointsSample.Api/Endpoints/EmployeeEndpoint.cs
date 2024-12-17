using FastEndpoints;
using FastEndpointsSample.ApplicationCore.Services;
using FastEndpointsSample.ApplicationCore.Mappers;
using FastEndpointsSample.ApplicationCore.Models.Response;

namespace FastEndpointsSample.Endpoints
{
    public class EmployeeEndpoint : Endpoint<int, GetEmployeeResponse, EmployeeMapper>
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeEndpoint(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public override void Configure()
        {
            Get("/api/Employees");
            AllowAnonymous();
        }

        public override async Task HandleAsync(int id, CancellationToken ct)
        {
            var response = Map.FromEntity(await _employeeService.GetEmployee(id));
            if (response is null)
            {
                await SendNotFoundAsync(ct);
                return;
            }
            await SendAsync(response);
        }
    }  
}

