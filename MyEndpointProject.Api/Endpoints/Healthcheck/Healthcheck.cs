using FastEndpoints;
using MyEndpointProject.ApplicationCore.Models.Response;
using MyEndpointProject.Infrastructure.Data;

namespace MyEndpointProject.Endpoints.Healthcheck;

public class Healthcheck(AdventureWorksContext dbContext) : EndpointWithoutRequest<HealthcheckResponse>
{
    public override void Configure()
    {
        Get("/healthcheck");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken cancellationToken)
    {
        if (await dbContext.Database.CanConnectAsync(cancellationToken))
        {
            await SendOkAsync(new HealthcheckResponse
            {
                Message = "Healthy"
            }, cancellationToken);
            return;
        }
        await SendAsync(new HealthcheckResponse
        {
            Message = "Cannot connect to the database."
        }, 500, cancellationToken);
    }
}