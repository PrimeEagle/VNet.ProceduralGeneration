using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmologicaPluginApi : ICosmologicaPluginApi
{
    public string ApiVersion
    {
        get => ConfigurationSettings<Settings>.AppSettings.Advanced.Plugin.ApiVersion;
        init { }
    }

    public string[] CompatibleApiVersions
    {
        get => ConfigurationSettings<Settings>.AppSettings.Advanced.Plugin.CompatibleApiVersions;
        init { }
    }
}