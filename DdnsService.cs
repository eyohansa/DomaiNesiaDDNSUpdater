namespace DomaiNesiaDDNSUpdater;

public class DdnsService
{
    readonly IConfiguration _config;

    public DdnsService(IConfiguration config)
    {
        _config = config;
    }

    public async Task Update()
    {
        using var http = new HttpClient();
        await http.SendAsync(new HttpRequestMessage(HttpMethod.Get, _config["DdnsUrl"]));
    }
}