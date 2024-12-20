dotnet ef dbcontext scaffold "Server=192.168.50.166;Database=AdventureWorks;User ID=sa;Password=Password323!;Encrypt=False" ^
Microsoft.EntityFrameworkCore.SqlServer ^
--output-dir ..\FastEndpoints.Infrastructure\Entities ^
--context AdventureWorksContext ^
--context-dir .\Data ^
--context-namespace FastEndpoints.Infrastructure.Data ^
--namespace FastEndpoints.Infrastructure.Entities ^
--force ^
--no-onconfiguring ^
--startup-project ..\MyEndpointProject.Api ^
-t HumanResources.Employee ^
-t HumanResources.EmployeeDepartmentHistory ^
-t HumanResources.EmployeePayHistory ^
-t Sales.*
