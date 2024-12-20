using FastEndpoints;
using MyEndpointProject.ApplicationCore.Models.Response;
using MyEndpointProject.Infrastructure.Entities;

namespace MyEndpointProject.ApplicationCore.Mappers;

public class EmployeeMapper : ResponseMapper<GetEmployeeResponse, Employee>
{
    public override GetEmployeeResponse? FromEntity(Employee source) => new()
    {
        JobTitle = source.JobTitle,
        BusinessEntityId = source.BusinessEntityId,
    };
}