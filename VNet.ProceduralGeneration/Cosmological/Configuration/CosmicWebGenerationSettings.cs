﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class CosmicWebGenerationSettings : ISettings
    {
        public CosmicWebGenerationEvolutionSettings Evolution { get; set; }
        public CosmicWebGenerationHeightmapSettings Heightmap { get; set; }
        public CosmicWebGenerationRandomizedSettings Randomized { get; set; }

        [Required]
        [DisplayName("Random Generator")]
        [Tooltip("The random generation algorithm to use.")]
        public IRandomGenerationAlgorithm RandomGenerator { get; init; }

        [DisplayName("Cosmic Web Generation Method")]
        [Tooltip("What method should be used for generating the structure of the cosmic web.")]
        public CosmicWebGenerationMethod CosmicWebGenerationMethod { get; init; }



        public CosmicWebGenerationSettings()
        {
            this.Evolution = new CosmicWebGenerationEvolutionSettings();
            this.Heightmap = new CosmicWebGenerationHeightmapSettings();
            this.Randomized = new CosmicWebGenerationRandomizedSettings();
            this.RandomGenerator = ConfigConstants.CosmicWeb.RandomGenerator;
            this.CosmicWebGenerationMethod = ConfigConstants.CosmicWeb.CosmicWebGenerationMethod;
        }
    }
}