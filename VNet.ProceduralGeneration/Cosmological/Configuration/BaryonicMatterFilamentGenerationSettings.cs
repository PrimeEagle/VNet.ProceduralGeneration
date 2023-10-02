﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterFilamentGenerationSettings : ISettings
    {
        [Range(0, double.MaxValue)]
        [DisplayName("Count Age Factor")]
        [Tooltip("Weighting factor for the age of the universe on baryonic matter (normal matter) filament count. Higher value results in more filaments.")]
        public double CountAgeFactor { get; init; }

        [Range(0, double.MaxValue)]
        [DisplayName("Count Mass Factor")]
        [Tooltip("Weighting factor for the mass of the universe on baryonic matter (normal matter) filament count. Higher value results in more filaments.")]
        public double CountMassFactor { get; init; }

        [Range(0, double.MaxValue)]
        [DisplayName("Count Size Factor")]
        [Tooltip("Weighting factor for the size of the universe on baryonic matter (normal matter) filament count. Higher value results in more filaments.")]
        public double CountSizeFactor { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CountDarkMatterPercentFactor), nameof(CountDarkEnergyPercentFactor) })]
        [DisplayName("Count Baryonic Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of baryonic matter (normal matter) in the universe on baryonic matter (normal matter) filament count. Higher value results in less filaments.")]
        public double CountBaryonicMatterPercentFactor { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CountBaryonicMatterPercentFactor), nameof(CountDarkEnergyPercentFactor) })]
        [DisplayName("Count Dark Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on baryonic matter (normal matter) filament count. Higher value results in less filaments.")]
        public double CountDarkMatterPercentFactor { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CountDarkMatterPercentFactor), nameof(CountBaryonicMatterPercentFactor) })]
        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark energy in the universe on baryonic matter (normal matter) filament count. Higher value results in more filaments.")]
        public double CountDarkEnergyPercentFactor { get; init; }




        public BaryonicMatterFilamentGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.BaryonicMatterFilament.CountAgeFactor;
            this.CountMassFactor = ConfigConstants.BaryonicMatterFilament.CountMassFactor;
            this.CountSizeFactor = ConfigConstants.BaryonicMatterFilament.CountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterFilament.CountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.BaryonicMatterFilament.CountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterFilament.CountDarkEnergyPercentFactor;
        }
    }
}