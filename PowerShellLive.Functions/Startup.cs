using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using PowerShellLive.Common;

[assembly: FunctionsStartup(typeof(PowerShellLive.Functions.Startup))]

namespace PowerShellLive.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddPowerShellLiveServices();
        }
    }
}