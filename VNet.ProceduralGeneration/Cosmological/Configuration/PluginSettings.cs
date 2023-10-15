using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;


namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class PluginSettings : ISettings
{
    [Required]
    [DisplayName("API Version")]
    [Tooltip("The version of the Plugin API.")]
    public string ApiVersion { get; init; }

    [Required]
    [DisplayName("Compatible API Versions")]
    [Tooltip("The versions of the Plugin API which are compatible with the current version.")]
    public string[] CompatibleApiVersions { get; init; }

    [Required]
    [DirectoryExists]
    [DisplayName("C# Plugin Folder")]
    [Tooltip("The folder that contains C# plugins that should be loaded.")]
    public string CSharpPluginFolder { get; init; }

    [Required]
    [DirectoryExists]
    [DisplayName("Lua Plugin Folder")]
    [Tooltip("The folder that contains Lua plugins that should be loaded.")]
    public string LuaPluginFolder { get; init; }

    public PluginSettings()
    {
        ApiVersion = Constants.Advanced.Plugin.ApiVersion;
        CompatibleApiVersions = Constants.Advanced.Plugin.CompatibleApiVersions;
        LuaPluginFolder = Constants.Advanced.Plugin.LuaPluginFolder;
        CSharpPluginFolder = Constants.Advanced.Plugin.CSharpPluginFolder;
    }
}