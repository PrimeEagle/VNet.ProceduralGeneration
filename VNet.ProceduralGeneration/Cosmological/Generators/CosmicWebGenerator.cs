using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.Scientific.NumericalVolumes;
using VNet.System.Events;

// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedParameter.Local
// ReSharper disable PossibleLossOfFraction
#pragma warning disable CS8618
#pragma warning disable CA2208


namespace VNet.ProceduralGeneration.Cosmological.Generators;

public partial class CosmicWebGenerator : GroupGeneratorBase<CosmicWeb, CosmicWebContext>
{
    public CosmicWebGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level0)
    {
        Enabled = ObjectToggles.CosmicWebEnabled;
    }

    protected override async Task<CosmicWeb> GenerateSelf(CosmicWebContext context, CosmicWeb self)
    {
        return self;
    }

    protected override async Task GenerateChildren(CosmicWebContext context, CosmicWeb self)
    {
        switch (AdvancedSettings.CosmicWeb.CosmicWebGenerationMethod)
        {
            case CosmicWebGenerationMethod.Heightmap:
                GenerateCosmicWebByHeightmap(context, self);
                break;
            case CosmicWebGenerationMethod.Random:
                GenerateCosmicWebRandomly(context, self);
                break;
            case CosmicWebGenerationMethod.Evolution:
                GenerateCosmicWebByEvolution(context, self);
                break;
            case CosmicWebGenerationMethod.None:
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}