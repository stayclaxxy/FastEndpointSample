namespace MyEndpointProject.ApplicationCore.Models.Response;

public class GetEmployeeResponse
{
    public string JobTitle { get; set; } = string.Empty;
    public int BusinessEntityId { get; set; }
    public DateOnly BirthDate { get; set; }
    public string MartialStatus { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public DateOnly HireDate { get; set; }
    public bool SalariedFlag { get; set; }
    public int VacationHours { get; set; }
    public int SickLeaveHours { get; set; }
}