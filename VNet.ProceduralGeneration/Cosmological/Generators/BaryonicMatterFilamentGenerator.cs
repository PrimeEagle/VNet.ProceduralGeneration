using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.Scientific.Noise;


namespace VNet.ProceduralGeneration.Cosmological;

public class BaryonicMatterFilamentGenerator : BaseGenerator<BaryonicMatterFilament, BaryonicMatterFilamentContext>
{
    private readonly SuperclusterGenerator _superclusterGenerator;
    private readonly GalaxyClusterGenerator _galaxyClusterGenerator;
    private readonly GalaxyGroupGenerator _galaxyGroupGenerator;
    private readonly GalaxyGenerator _galaxyGenerator;
    private readonly NoiseLayer _positionNoiseLayer;
    private readonly NoiseLayer _orientationNoiseLayer;
    private const float scaleX = 1.0f;
    private const float scaleY = 1.0f;
    private const float scaleZ = 1.0f;
    private const float angleX = 1.0f;
    private const float angleY = 1.0f;
    private const float angleZ = 1.0f;


    public BaryonicMatterFilamentGenerator()
    {
        _superclusterGenerator = new SuperclusterGenerator();
        _galaxyClusterGenerator = new GalaxyClusterGenerator();
        _galaxyGroupGenerator = new GalaxyGroupGenerator();
        _galaxyGenerator = new GalaxyGenerator();
    }

    public async override Task<BaryonicMatterFilament> Generate(BaryonicMatterFilamentContext context)
    {
        var filamentPositionValue = _positionNoiseLayer.GenerateSingleSample();
        var filamentOrientationValue = _orientationNoiseLayer.GenerateSingleSample();

        var filament = new BaryonicMatterFilament
        {
            Position = ConvertNoiseToPosition(filamentPositionValue),
            Orientation = ConvertNoiseToOrientation(filamentOrientationValue),
        };

        var superclusterContext = new SuperclusterContext();
        Parallel.For(0, GetSuperclusterCount(context), i =>
        {
            var supercluster = _superclusterGenerator.Generate(superclusterContext);
            filament.Superclusters.Add(supercluster);
        });

        var galaxyClusterContext = new GalaxyClusterContext();
        Parallel.For(0, GetGalaxyClusterCount(context), i =>
        {
            var galaxyCluster = _galaxyClusterGenerator.Generate(galaxyClusterContext);
            filament.GalaxyClusters.Add(galaxyCluster);
        });

        var galaxyGroupContext = new GalaxyGroupContext();
        Parallel.For(0, GetGalaxyGroupCount(context), i =>
        {
            var galaxyGroup = _galaxyGroupGenerator.Generate(galaxyGroupContext);
            filament.GalaxyGroups.Add(galaxyGroup);
        });

        var galaxyContext = new GalaxyContext();
        Parallel.For(0, GetGalaxyCount(context), i =>
        {
            var galaxy = _galaxyGenerator.Generate(galaxyContext);
            filament.Galaxies.Add(galaxy);
        });

        PostProcess();

        return filament;
    }

    private Vector3 ConvertNoiseToPosition(double noiseValue)
    {
        return new Vector3((float)(noiseValue * scaleX), (float)(noiseValue * scaleY), (float)(noiseValue * scaleZ));
    }

    private Vector3 ConvertNoiseToOrientation(double noiseValue)
    {
        return new Vector3((float)(noiseValue * angleX), (float)(noiseValue * angleY), (float)(noiseValue * angleZ));
    }

    private int GetSuperclusterCount(BaryonicMatterFilamentContext context)
    {
        return 0;
    }

    private int GetGalaxyClusterCount(BaryonicMatterFilamentContext context)
    {
        return 0;
    }

    private int GetGalaxyGroupCount(BaryonicMatterFilamentContext context)
    {
        return 0;
    }

    private int GetGalaxyCount(BaryonicMatterFilamentContext context)
    {
        return 0;
    }

    private void PostProcess()
    {
        ApplyGravitationalAdjustment();
    }

    private void ApplyGravitationalAdjustment()
    {

    }
}