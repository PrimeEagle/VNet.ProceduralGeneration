using Microsoft.Extensions.Options;
using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmologicaPluginApi : ICosmologicaPluginApi
{
    private readonly PluginSettings _pluginSettings;

    public string ApiVersion
    {
        get => _pluginSettings.ApiVersion;
        init { }
    }

    public string[] CompatibleApiVersions
    {
        get => _pluginSettings.CompatibleApiVersions;
        init { }
    }




    public CosmologicaPluginApi(IOptions<PluginSettings> pluginSettings)
    {
        _pluginSettings = pluginSettings.Value;
    }
}