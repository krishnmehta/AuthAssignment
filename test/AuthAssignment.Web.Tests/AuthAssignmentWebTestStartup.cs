using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace AuthAssignment;

public class AuthAssignmentWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<AuthAssignmentWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
