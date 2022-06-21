using DomaiNesiaDDNSUpdater;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<DdnsService>();
        services.AddHostedService<Worker>();
    })
    .Build();


await host.RunAsync();
