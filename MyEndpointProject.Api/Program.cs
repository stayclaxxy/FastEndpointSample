using MyEndpointProject.ApplicationCore.Services;
using FastEndpoints;
using MyEndpointProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using FastEndpoints.Swagger;

var bld = WebApplication.CreateBuilder();

bld.Services.AddDbContext<AdventureWorksContext>(options =>
{
    options.UseSqlServer(bld.Configuration.GetConnectionString("AdventureWorksConnection"));
});

bld.Services.AddScoped<IEmployeeService, EmployeeService>();
bld.Services.AddFastEndpoints()
    .SwaggerDocument(o =>
    {
        o.EnableJWTBearerAuth = false;
    });

var app = bld.Build();

app.UseFastEndpoints(o =>
{
    o.Endpoints.RoutePrefix = "api";
}).UseSwaggerGen();
app.Run();