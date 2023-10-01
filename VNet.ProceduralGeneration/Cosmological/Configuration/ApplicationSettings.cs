﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class ApplicationSettings : ISettings
    {
        [Required]
        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 1 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 1 objects are the highest level in the hierarchy and benefit the most from higher levels of parallelism.")]
        public int MaxDegreesOfParallelismLevel1 { get; init; }

        [Required]
        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 2 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 2 objects are intermediate in the hierarchy and benefit from higher levels of parallelism more than Level 3 and 4 objects, but less than Level 1 objects.")]
        public int MaxDegreesOfParallelismLevel2 { get; init; }

        [Required]
        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 3 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 3 objects are intermediate in the hierarchy and benefit from higher levels of parallelism more than Level 4 objects, but less than Level 1 and 2 objects.")]
        public int MaxDegreesOfParallelismLevel3 { get; init; }

        [Required]
        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 4 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 4 objects are the lowest in the hierarchy and benefit the least from higher levels of parallelism.")]
        public int MaxDegreesOfParallelismLevel4 { get; init; }

        [Required]
        [DisplayName("Random Generator")]
        [Tooltip("The random generation algorithm to use.")]
        public IRandomGenerationAlgorithm RandomGenerator { get; init; }



        public ApplicationSettings()
        {
            this.MaxDegreesOfParallelismLevel1 = ConfigConstants.MaxDegreesOfParallelismLevel1;
            this.MaxDegreesOfParallelismLevel2 = ConfigConstants.MaxDegreesOfParallelismLevel2;
            this.MaxDegreesOfParallelismLevel3 = ConfigConstants.MaxDegreesOfParallelismLevel3;
            this.MaxDegreesOfParallelismLevel4 = ConfigConstants.MaxDegreesOfParallelismLevel4;
            this.RandomGenerator = new DotNetGenerator();
        }
    }
}