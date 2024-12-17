using FastEndpoints;
using FastEndpointsSample.ApplicationCore.Models.Response;
using FastEndpointsSample.Infrastructure.Entities;

namespace FastEndpointsSample.ApplicationCore.Mappers;

public class EmployeeMapper : ResponseMapper<GetEmployeeResponse, Employee>
{
    public override GetEmployeeResponse? FromEntity(Employee source) => new()
    {
        JobTitle = source.JobTitle,
        BusinessEntityId = source.BusinessEntityId,
    };
}