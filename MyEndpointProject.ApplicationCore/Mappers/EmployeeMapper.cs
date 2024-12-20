using FastEndpoints;
using MyEndpointProject.ApplicationCore.Models.Response;
using MyEndpointProject.Infrastructure.Entities;

namespace MyEndpointProject.ApplicationCore.Mappers;

public class EmployeeMapper : ResponseMapper<GetEmployeeResponse, Employee>
{
    public override Task<GetEmployeeResponse> FromEntityAsync(Employee source, CancellationToken ct = default)
        => Task.FromResult(new GetEmployeeResponse
        {
            JobTitle = source.JobTitle,
            BusinessEntityId = source.BusinessEntityId,
            BirthDate = source.BirthDate,
            MartialStatus = source.MaritalStatus,
            Gender = source.Gender,
            HireDate = source.HireDate,
            SalariedFlag = source.SalariedFlag,
            VacationHours = source.VacationHours,
            SickLeaveHours = source.SickLeaveHours
        });
}