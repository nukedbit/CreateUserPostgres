[assembly: HostingStartup(typeof(CreateUserPostgres.AppHost))]

namespace CreateUserPostgres;

public class AppHost() : AppHostBase("CreateUserPostgres"), IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices((context, services) =>
        {
            // Configure ASP.NET Core IOC Dependencies
        });

    // Configure your AppHost with the necessary configuration and dependencies your App needs
    public override void Configure()
    {
        SetConfig(new HostConfig {
        });
    }
}
