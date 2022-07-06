namespace DomaiNesiaDDNSUpdater;

public class DdnsService
{
    readonly IConfiguration _config;
    readonly ILogger<DdnsService> _logger;
    readonly HttpClient _http;

    public DdnsService(
        IConfiguration config,
        ILogger<DdnsService> logger) =>
        (_config, _logger, _http) = (config, logger, new HttpClient());

    public async Task Update()
    {
        try
        {
            await _http.GetAsync(_config["DdnsUrl"]);
        }
        catch (Exception e)
        {
            _logger.LogError(e, $"{e.Message}");

            // Terminate gracefully and recover accordingly.
            Environment.Exit(1);
        }
    }
}