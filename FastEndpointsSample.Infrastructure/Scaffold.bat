dotnet ef dbcontext scaffold "Server=redacted" ^
Microsoft.EntityFrameworkCore.SqlServer ^
--output-dir ..\FastEndpoints.Infrastructure\Entities ^
--context AdventureWorksContext ^
--context-dir .\Data ^
--context-namespace FastEndpoints.Infrastructure.Data ^
--namespace FastEndpoints.Infrastructure.Entities ^
--force ^
--no-onconfiguring ^
--startup-project ..\FastEndpoints.Api ^
-t HumanResources.Employee ^
-t HumanResources.EmployeeDepartmentHistory ^
-t HumanResources.EmployeePayHistory ^
-t Sales.*
