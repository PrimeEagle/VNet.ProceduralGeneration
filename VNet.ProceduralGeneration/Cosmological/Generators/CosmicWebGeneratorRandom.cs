//using System.Numerics;
//using VNet.Mathematics.Randomization.Generation;
//using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
//using VNet.ProceduralGeneration.Cosmological.Contexts;
//using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
//using VNet.ProceduralGeneration.Cosmological.Enum;
//using VNet.ProceduralGeneration.Cosmological.Generators.Base;
//using VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;
//using Void = VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base.Void;

//// ReSharper disable SuggestBaseTypeForParameter
//// ReSharper disable MemberCanBeMadeStatic.Local
//// ReSharper disable ClassNeverInstantiated.Global
//#pragma warning disable CA1822


//namespace VNet.ProceduralGeneration.Cosmological.Generators;

//public partial class CosmicWebGenerator : GroupGeneratorBase<CosmicWeb, CosmicWebContext>
//{
//    private void GenerateCosmicWebRandomly(CosmicWebContext context, CosmicWeb self)
//    {
//        GenerateRandomVoids(context, self, MatterType.BaryonicMatter);


//        GenerateRandomVoids(context, self, MatterType.BaryonicMatter);
//    }

//    private async void GenerateRandomVoids(CosmicWebContext context, CosmicWeb self, MatterType matterType)
//    {
//        var volumeSize = Settings.Basic.DimensionX * Settings.Basic.DimensionY * Settings.Basic.DimensionZ;
//        var targetTotalVoidVolume = volumeSize * GetPercentageOfVolumeCoveredByVoids(matterType) / 100;
//        var totalVoidVolume = 0d;
//        var voids = new List<Void>();

//        while (targetTotalVoidVolume > totalVoidVolume)
//        {
//            switch (matterType)
//            {
//                case MatterType.BaryonicMatter:
//                    var baryonicMatterVoidContext = new BaryonicMatterVoidContext
//                    {
//                        DiameterCreateRange = (GetMinimumVoidDiameter(matterType), GetMaximumVoidDiameter(matterType)),
//                        RandomizationAlgorithm = GetVoidRandomizationAlgorithm(matterType)
//                    };
//                    var baryonicMatterVoidGenerator = new BaryonicMatterVoidGenerator(EventAggregator, ParallelismLevel.Level1);
//                    var newBaryonicMatterVoid = await baryonicMatterVoidGenerator.Generate(baryonicMatterVoidContext, self.Parent);

//                    baryonicMatterVoidContext.PositionXCreateRange = (0, Settings.Basic.DimensionX - newBaryonicMatterVoid.Diameter);
//                    baryonicMatterVoidContext.PositionYCreateRange = (0, Settings.Basic.DimensionY - newBaryonicMatterVoid.Diameter);
//                    baryonicMatterVoidContext.PositionZCreateRange = (0, Settings.Basic.DimensionZ - newBaryonicMatterVoid.Diameter);
//                    baryonicMatterVoidGenerator.GeneratePosition(baryonicMatterVoidContext, newBaryonicMatterVoid);

//                    self.BaryonicMatterVoids.Add(newBaryonicMatterVoid);
//                    totalVoidVolume += newBaryonicMatterVoid.Volume;
//                    break;
//                case MatterType.DarkMatter:
//                    var darkMatterVoidContext = new DarkMatterVoidContext
//                    {
//                        DiameterCreateRange = (GetMinimumVoidDiameter(matterType), GetMaximumVoidDiameter(matterType)),
//                        RandomizationAlgorithm = GetVoidRandomizationAlgorithm(matterType)
//                    };
//                    var darkMatterVoidGenerator = new DarkMatterVoidGenerator(EventAggregator, ParallelismLevel.Level1);
//                    var newDarkMatterVoid = await darkMatterVoidGenerator.Generate(darkMatterVoidContext, self.Parent);

//                    darkMatterVoidContext.PositionXCreateRange = (0, Settings.Basic.DimensionX - newDarkMatterVoid.Diameter);
//                    darkMatterVoidContext.PositionYCreateRange = (0, Settings.Basic.DimensionY - newDarkMatterVoid.Diameter);
//                    darkMatterVoidContext.PositionZCreateRange = (0, Settings.Basic.DimensionZ - newDarkMatterVoid.Diameter);
//                    darkMatterVoidGenerator.GeneratePosition(darkMatterVoidContext, newDarkMatterVoid);

//                    self.DarkMatterVoids.Add(newDarkMatterVoid);
//                    totalVoidVolume += newDarkMatterVoid.Volume;
//                    break;
//                case MatterType.None:
//                case MatterType.Mixed:
//                default:
//                    throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null);
//            }


//            var acceptableOverlap = false;
//            while (!acceptableOverlap)
//            {
//                var overlapAmount = CalculateOverlapAmount(sphere, spheres);

//                if (overlapAmount < GetMinimumVoidOverlap(matterType) || overlapAmount > GetMaximumVoidOverlap(matterType) ||
//                    spheres.Count(x => CalculateOverlapAmount(sphere, new List<VSphere> { x }) > 0) / (float)spheres.Count > GetPercentageOfOverlappingVoids(matterType))
//                    sphere = new VSphere(new Vector3(
//                        RandomAlgorithm.NextSingle() * (volume.GetLength(0) - diameter),
//                        RandomAlgorithm.NextSingle() * (volume.GetLength(1) - diameter),
//                        RandomAlgorithm.NextSingle() * (volume.GetLength(2) - diameter)
//                    ), diameter);
//                else
//                    acceptableOverlap = true;
//            }

//            spheres.Add(sphere);
//            targetSphereVolume -= sphereVolume;
//        }

//        return spheres;
//    }

//    private float CalculateOverlapAmount(Void voidItem, List<Void> existingVoids)
//    {
//        float overlapAmount = 0;

//        foreach (var existingVoid in existingVoids)
//        {
//            var distanceBetweenCenters = Vector3.Distance(voidItem.Position, existingVoid.Position);
//            var combinedRadii = voidItem.Radius + existingVoid.Radius;

//            if (distanceBetweenCenters < combinedRadii) overlapAmount += combinedRadii - distanceBetweenCenters;
//        }

//        return overlapAmount;
//    }

//    private float GetPercentageOfVolumeCoveredByVoids(MatterType matterType)
//    {
//        return matterType switch
//        {
//            MatterType.BaryonicMatter => Settings.Advanced.CosmicWeb.Randomized.PercentageOfVolumeCoveredByBaryonicMatterVoids,
//            MatterType.DarkMatter => Settings.Advanced.CosmicWeb.Randomized.PercentageOfVolumeCoveredByDarkMatterMatterVoids,
//            MatterType.None => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null),
//            _ => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null)
//        };
//    }

//    private float GetMaximumVoidDiameter(MatterType matterType)
//    {
//        return matterType switch
//        {
//            MatterType.BaryonicMatter => Settings.Advanced.CosmicWeb.Randomized.MaximumBaryonicMatterVoidDiameter,
//            MatterType.DarkMatter => Settings.Advanced.CosmicWeb.Randomized.MaximumDarkMatterVoidDiameter,
//            MatterType.None => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null),
//            _ => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null)
//        };
//    }

//    private float GetMinimumVoidDiameter(MatterType matterType)
//    {
//        return matterType switch
//        {
//            MatterType.BaryonicMatter => Settings.Advanced.CosmicWeb.Randomized.MinimumBaryonicMatterVoidDiameter,
//            MatterType.DarkMatter => Settings.Advanced.CosmicWeb.Randomized.MinimumDarkMatterVoidDiameter,
//            MatterType.None => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null),
//            _ => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null)
//        };
//    }

//    private float GetMaximumVoidOverlap(MatterType matterType)
//    {
//        return matterType switch
//        {
//            MatterType.BaryonicMatter => Settings.Advanced.CosmicWeb.Randomized.MaximumBaryonicMatterVoidOverlap,
//            MatterType.DarkMatter => Settings.Advanced.CosmicWeb.Randomized.MaximumDarkMatterVoidOverlap,
//            MatterType.None => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null),
//            _ => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null)
//        };
//    }

//    private float GetMinimumVoidOverlap(MatterType matterType)
//    {
//        return matterType switch
//        {
//            MatterType.BaryonicMatter => Settings.Advanced.CosmicWeb.Randomized.MinimumBaryonicMatterVoidOverlap,
//            MatterType.DarkMatter => Settings.Advanced.CosmicWeb.Randomized.MinimumDarkMatterVoidOverlap,
//            MatterType.None => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null),
//            _ => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null)
//        };
//    }

//    private float GetPercentageOfOverlappingVoids(MatterType matterType)
//    {
//        return matterType switch
//        {
//            MatterType.BaryonicMatter => Settings.Advanced.CosmicWeb.Randomized.PercentageOfOverlappingBaryonicMatterVoids,
//            MatterType.DarkMatter => Settings.Advanced.CosmicWeb.Randomized.PercentageOfOverlappingDarkMatterVoids,
//            MatterType.None => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null),
//            _ => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null)
//        };
//    }

//    private IRandomGenerationAlgorithm GetVoidRandomizationAlgorithm(MatterType matterType)
//    {
//        return matterType switch
//        {
//            MatterType.BaryonicMatter => Settings.Advanced.CosmicWeb.Randomized.BaryonicMatterRandomizationAlgorithm,
//            MatterType.DarkMatter => Settings.Advanced.CosmicWeb.Randomized.DarkMatterRandomizationAlgorithm,
//            MatterType.None => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null),
//            _ => throw new ArgumentOutOfRangeException(nameof(matterType), matterType, null)
//        };
//    }
//}