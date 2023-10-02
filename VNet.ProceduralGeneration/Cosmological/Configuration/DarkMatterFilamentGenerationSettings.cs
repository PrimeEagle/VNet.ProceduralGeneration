﻿using System.ComponentModel;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterFilamentGenerationSettings : ISettings
    {
        [DisplayName("Count Age Factor")]
        [Tooltip("Weighting factor for the age of the universe on dark matter filament count. Higher value results in more filaments.")]
        public double CountAgeFactor { get; init; }

        [DisplayName("Count Mass Factor")]
        [Tooltip("Weighting factor for the age of the universe on dark matter filament count. Higher value results in more filaments.")]
        public double CountMassFactor { get; init; }

        [DisplayName("Count Size Factor")]
        [Tooltip("Weighting factor for the size of the universe on dark matter filament count. Higher value results in more filaments.")]
        public double CountSizeFactor { get; init; }

        [DisplayName("Count Baryonic Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter filament count. Higher value results in more filaments.")]
        public double CountBaryonicMatterPercentFactor { get; init; }

        [DisplayName("Count Dark Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter filament count. Higher value results in less filaments.")]
        public double CountDarkMatterPercentFactor { get; init; }

        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark energy in the universe on dark matter filament count. Higher value results in more filaments.")]
        public double CountDarkEnergyPercentFactor { get; init; }




        public DarkMatterFilamentGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.DarkMatterFilament.CountAgeFactor;
            this.CountMassFactor = ConfigConstants.DarkMatterFilament.CountMassFactor;
            this.CountSizeFactor = ConfigConstants.DarkMatterFilament.CountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterFilament.CountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.DarkMatterFilament.CountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterFilament.CountDarkEnergyPercentFactor;
        }
    }
}