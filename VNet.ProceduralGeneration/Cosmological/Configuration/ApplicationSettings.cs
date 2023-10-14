﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
using VNet.ProceduralGeneration.Cosmological.Enum;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

// ReSharper disable ClassNeverInstantiated.Global

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class ApplicationSettings : ISettings
{
    public ApplicationSettings()
    {
        MaxDegreesOfParallelismLevel1 = ConfigConstants.Application.MaxDegreesOfParallelismLevel1;
        MaxDegreesOfParallelismLevel2 = ConfigConstants.Application.MaxDegreesOfParallelismLevel2;
        MaxDegreesOfParallelismLevel3 = ConfigConstants.Application.MaxDegreesOfParallelismLevel3;
        MaxDegreesOfParallelismLevel4 = ConfigConstants.Application.MaxDegreesOfParallelismLevel4;
        LengthConversionFactor = ConfigConstants.Application.LengthConversionFactor;
        MassConversionFactor = ConfigConstants.Application.MassConversionFactor;
        TemperatureConversionFactor = ConfigConstants.Application.TemperatureConversionFactor;
        TimeConversionFactor = ConfigConstants.Application.TimeConversionFactor;
        LuminosityConversionFactor = ConfigConstants.Application.LuminosityConversionFactor;
        ElectricalCurrentConversionFactor = ConfigConstants.Application.ElectricalCurrentConversionFactor;
        SizeMeaning = ConfigConstants.Application.SizeMeaning;
        ApplyGravitationalEffectsPreventDarkMatterClumping = ConfigConstants.Application.ApplyGravitationalEffectsPreventDarkMatterClumping;
        ApplyGravitationalEffectsDampenBaryonicMatter = ConfigConstants.Application.ApplyGravitationalEffectsDampenBaryonicMatter;
        MinimumDarkMatterDistanceToPreventClumping = ConfigConstants.Application.MinimumDarkMatterDistanceToPreventClumping;
        BaryonicMatterDampeningFactor = ConfigConstants.Application.BaryonicMatterDampeningFactor;
    }

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

    [DisplayName("Prevent Dark Matter Clumping")]
    [Tooltip("If 'Apply Gravitational Effects' is enabled, determines whether dark matter clumping should be prevented.")]
    public bool ApplyGravitationalEffectsPreventDarkMatterClumping { get; init; }

    [DisplayName("Dampen Baryonic Matter")]
    [Tooltip("If 'Apply Gravitational Effects' is enabled, determines whether the gravitation effects on baryonic matter should be dampened.")]
    public bool ApplyGravitationalEffectsDampenBaryonicMatter { get; init; }

    [RequiredIfTrue(nameof(ApplyGravitationalEffectsPreventDarkMatterClumping))]
    [DisplayName("Minimum Dark Matter Distance to Prevent Clumping")]
    [Tooltip("If 'Prevent Dark Matter Clumping' is enabled, the minimum distance allowed between dark matter.")]
    public float MinimumDarkMatterDistanceToPreventClumping { get; init; }

    [RequiredIfTrue(nameof(ApplyGravitationalEffectsDampenBaryonicMatter))]
    [Range(0, 1)]
    [DisplayName("Baryonic Matter Dampening Factor")]
    [Tooltip("If 'Dampen Baryonic Matter' is enabled, the dampening factor applied to baryonic matter.")]
    public float BaryonicMatterDampeningFactor { get; init; }
}