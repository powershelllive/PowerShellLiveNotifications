# Dependency Injection

## Common

Dependency injection logic should be centralized in `PowerShellLive.Common.ServicesConfiguration`.
This is accomplished by using an `IServiceCollection` extension method.
This allows for multiple runtime environments (Azure Functions, Console App, ASP.NET, etc) to be consistent.

## Azure Functions

Dependency injection is managed in `PowerShellLive.Functions.Startup`.
[Use dependency injection in .NET Azure Functions](https://docs.microsoft.com/en-us/azure/azure-functions/functions-dotnet-dependency-injection#customizing-configuration-sources) contains documentation on how to use DI in Azure Functions.
