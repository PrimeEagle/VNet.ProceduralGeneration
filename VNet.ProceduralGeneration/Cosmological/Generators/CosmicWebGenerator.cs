using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.Scientific.NumericalVolumes;
using VNet.System.Events;
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedParameter.Local
// ReSharper disable PossibleLossOfFraction
#pragma warning disable CS8618
#pragma warning disable CA2208


namespace VNet.ProceduralGeneration.Cosmological.Generators;

public partial class CosmicWebGenerator : ContainerGeneratorBase<CosmicWeb, CosmicWebContext>
{
    public CosmicWebGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level0)
    {
        Enabled = ObjectToggles.CosmicWebEnabled;
    }

    protected override void GenerateDiameter(CosmicWebContext context, CosmicWeb self)
    {
        self.Diameter = (context.MapX + context.MapY + context.MapZ) / 3;
    }

    protected override void GeneratePosition(CosmicWebContext context, CosmicWeb self)
    {
        self.Position = new Vector3(0, 0, 0);
    }

    protected override void GenerateBoundingBox(CosmicWebContext context, CosmicWeb self)
    {
        self.BoundingBox = new BoundingBox<float>(self.Position, 1, self.Orientation);
    }

    protected override void GenerateOrientation(CosmicWebContext context, CosmicWeb self)
    {
        self.Orientation = Vector3.UnitZ;
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
                GenerateCosmicWebByHeightmap(self);
                break;
            case CosmicWebGenerationMethod.Random:
                GenerateCosmicWebRandomly(self);
                break;
            case CosmicWebGenerationMethod.Evolution:
                GenerateCosmicWebByEvolution(self);
                break;
            case CosmicWebGenerationMethod.None:
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}