using System.Numerics;
using VNet.Scientific.Noise;


namespace VNet.ProceduralGeneration.Cosmological;

public class FilamentGenerator : BaseGenerator<Filament, FilamentContext>
{
    private readonly SuperclusterGenerator _superclusterGenerator;
    private readonly GalaxyClusterGenerator _galaxyClusterGenerator;
    private readonly GalaxyGroupGenerator _galaxyGroupGenerator;
    private readonly GalaxyGenerator _galaxyGenerator;
    private readonly IntergalacticMediumGenerator _intergalacticMediumGenerator;
    private readonly NoiseLayer _positionNoiseLayer;
    private readonly NoiseLayer _orientationNoiseLayer;
    private const float scaleX = 1.0f;
    private const float scaleY = 1.0f;
    private const float scaleZ = 1.0f;
    private const float angleX = 1.0f;
    private const float angleY = 1.0f;
    private const float angleZ = 1.0f;


    public FilamentGenerator(GeneratorConfig config) : base(config)
    {
        _superclusterGenerator = new SuperclusterGenerator(config);
        _galaxyClusterGenerator = new GalaxyClusterGenerator(config);
        _galaxyGroupGenerator = new GalaxyGroupGenerator(config);
        _galaxyGenerator = new GalaxyGenerator(config);
        _intergalacticMediumGenerator = new IntergalacticMediumGenerator(config);

        _positionNoiseLayer = new NoiseLayer();
        _positionNoiseLayer.AddLayer(new SomePositionNoiseAlgorithm(), new OverlayBlendMode());

        _orientationNoiseLayer = new NoiseLayer();
        _orientationNoiseLayer.AddLayer(new SomeOrientationNoiseAlgorithm(), new OverlayBlendMode());
    }

    public override Filament Generate(FilamentContext context)
    {
        var filamentPositionValue = _positionNoiseLayer.GenerateSingleSample();
        var filamentOrientationValue = _orientationNoiseLayer.GenerateSingleSample();

        var filament = new Filament
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

        var intergalacticMediumContext = new IntergalacticMediumContext();
        var imgTask = Task.Run(() => _intergalacticMediumGenerator.Generate(intergalacticMediumContext));

        Task.WaitAll(imgTask);

        filament.IntergalacticMedium = imgTask.Result;

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

    private int GetSuperclusterCount(FilamentContext context)
    {
        return 0;
    }

    private int GetGalaxyClusterCount(FilamentContext context)
    {
        return 0;
    }

    private int GetGalaxyGroupCount(FilamentContext context)
    {
        return 0;
    }

    private int GetGalaxyCount(FilamentContext context)
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