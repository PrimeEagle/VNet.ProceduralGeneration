using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
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




        public PluginSettings()
        {
            this.ApiVersion = ConfigConstants.Plugin.ApiVersion;
            this.CompatibleApiVersions = ConfigConstants.Plugin.CompatibleApiVersions;
        }
    }
}