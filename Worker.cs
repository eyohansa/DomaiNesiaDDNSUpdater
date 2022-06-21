namespace DomaiNesiaDDNSUpdater;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    readonly DdnsService _ddns;

    public Worker(
        ILogger<Worker> logger,
        DdnsService ddns)
    {
        _logger = logger;
        _ddns = ddns;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await _ddns.Update();

            await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
        }
    }
}
