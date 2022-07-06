namespace DomaiNesiaDDNSUpdater;

public class DdnsService
{
    readonly IConfiguration _config;
    readonly HttpClient _http;

    public DdnsService(IConfiguration config)
    {
        _config = config;
        _http = new HttpClient();
    }

    public async Task Update()
    {
        await _http.GetAsync(_config["DdnsUrl"]);
    }
}