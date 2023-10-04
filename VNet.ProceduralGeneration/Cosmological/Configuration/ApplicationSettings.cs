using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
using VNet.ProceduralGeneration.Cosmological.Enum;

// ReSharper disable ClassNeverInstantiated.Global

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class ApplicationSettings : ISettings
    {
        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 1 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 1 objects are the highest level in the hierarchy and benefit the most from higher levels of parallelism.")]
        public int MaxDegreesOfParallelismLevel1 { get; init; }

        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 2 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 2 objects are intermediate in the hierarchy and benefit from higher levels of parallelism more than Level 3 and 4 objects, but less than Level 1 objects.")]
        public int MaxDegreesOfParallelismLevel2 { get; init; }

        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 3 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 3 objects are intermediate in the hierarchy and benefit from higher levels of parallelism more than Level 4 objects, but less than Level 1 and 2 objects.")]
        public int MaxDegreesOfParallelismLevel3 { get; init; }

        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 4 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 4 objects are the lowest in the hierarchy and benefit the least from higher levels of parallelism.")]
        public int MaxDegreesOfParallelismLevel4 { get; init; }

        [Required]
        [DisplayName("Units for Length")]
        [Tooltip("The units used for displaying all length values.")]
        public string UnitsLength { get; init; }

        [DisplayName("Length Conversion Factor")]
        [Tooltip("The conversion factor to convert length units from AU to the custom 'Units for Length'. Value = 0 means no conversion.")]
        public double LengthConversionFactor { get; init; }

        [Required]
        [DisplayName("Units for Mass")]
        [Tooltip("The units used for displaying all mass values.")]
        public string UnitsMass { get; init; }

        [DisplayName("Mass Conversion Factor")]
        [Tooltip("The conversion factor to convert mass units from kg to the custom 'Units for Mass'. Value = 0 means no conversion.")]
        public double MassConversionFactor { get; init; }

        [Required]
        [DisplayName("Units for Temperature")]
        [Tooltip("The units used for displaying all temperature values.")]
        public string UnitsTemperature { get; init; }

        [DisplayName("Temperature Conversion Factor")]
        [Tooltip("The conversion factor to convert temperature units from Kelvin to the custom 'Units for Temperature'. Value = 0 means no conversion.")]
        public double TemperatureConversionFactor { get; init; }

        [Required]
        [DisplayName("Units for Time")]
        [Tooltip("The units used for displaying all time values.")]
        public string UnitsTime { get; init; }

        [DisplayName("Time Conversion Factor")]
        [Tooltip("The conversion factor to convert time units from years to the custom 'Units for Time'. Value = 0 means no conversion.")]
        public double TimeConversionFactor { get; init; }

        [Required]
        [DisplayName("Units for Luminosity")]
        [Tooltip("The units used for displaying all luminosity values.")]
        public string UnitsLuminosity { get; init; }

        [DisplayName("Luminosity Conversion Factor")]
        [Tooltip("The conversion factor to convert luminosity units from L\u2299 to the custom 'Units for Luminosity'. Value = 0 means no conversion.")]
        public float LuminosityConversionFactor { get; init; }

        [Required]
        [DisplayName("Units for Electrical Current")]
        [Tooltip("The units used for displaying all electrical current values.")]
        public string UnitsElectricalCurrent { get; init; }

        [DisplayName("Electrical Current Conversion Factor")]
        [Tooltip("The conversion factor to convert luminosity units from amps to the custom 'Units for Electrical Current'. Value = 0 means no conversion.")]
        public double ElectricalCurrentConversionFactor { get; init; }

        [DisplayName("Size Meaning")]
        [Tooltip("Whether 'size' refers to the radius, diameter, or volume of an object.")]
        public SizeType SizeMeaning { get; set; }

        [Required]
        [DirectoryExists]
        [DisplayName("Lua Plugin Folder")]
        [Tooltip("The folder that contains Lua plugins that should be loaded.")]
        public string LuaPluginFolder { get; init; }

        [Required]
        [DirectoryExists]
        [DisplayName("C# Plugin Folder")]
        [Tooltip("The folder that contains C# plugins that should be loaded.")]
        public string CSharpPluginFolder { get; init; }




        public ApplicationSettings()
        {
            this.MaxDegreesOfParallelismLevel1 = ConfigConstants.Application.MaxDegreesOfParallelismLevel1;
            this.MaxDegreesOfParallelismLevel2 = ConfigConstants.Application.MaxDegreesOfParallelismLevel2;
            this.MaxDegreesOfParallelismLevel3 = ConfigConstants.Application.MaxDegreesOfParallelismLevel3;
            this.MaxDegreesOfParallelismLevel4 = ConfigConstants.Application.MaxDegreesOfParallelismLevel4;
            this.LengthConversionFactor = ConfigConstants.Application.LengthConversionFactor;
            this.MassConversionFactor = ConfigConstants.Application.MassConversionFactor;
            this.TemperatureConversionFactor = ConfigConstants.Application.TemperatureConversionFactor;
            this.TimeConversionFactor = ConfigConstants.Application.TimeConversionFactor;
            this.LuminosityConversionFactor = ConfigConstants.Application.LuminosityConversionFactor;
            this.ElectricalCurrentConversionFactor = ConfigConstants.Application.ElectricalCurrentConversionFactor;
            this.SizeMeaning = ConfigConstants.Application.SizeMeaning;
            this.LuaPluginFolder = ConfigConstants.Application.LuaPluginFolder;
            this.CSharpPluginFolder = ConfigConstants.Application.CSharpPluginFolder;
        }
    }
}