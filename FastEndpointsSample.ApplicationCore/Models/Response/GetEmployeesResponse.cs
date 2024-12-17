namespace FastEndpointsSample.ApplicationCore.Models.Response;

public class GetEmployeeResponse
{
    public string JobTitle { get; set; } = string.Empty;
    public int BusinessEntityId { get; set; }
}