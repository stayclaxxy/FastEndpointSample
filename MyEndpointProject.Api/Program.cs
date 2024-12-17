using FastEndpointsSample.ApplicationCore.Services;
using FastEndpoints;
using FastEndpointsSample.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using FastEndpoints.Swagger;

var bld = WebApplication.CreateBuilder();

bld.Services.AddDbContext<AdventureWorksContext>(options =>
{
    options.UseSqlServer(bld.Configuration.GetConnectionString("AdventureWorksConnection"));
});

bld.Services.AddScoped<IEmployeeService, EmployeeService>();
bld.Services.AddFastEndpoints().SwaggerDocument();

var app = bld.Build();

app.UseFastEndpoints().UseSwaggerGen();
app.Run();