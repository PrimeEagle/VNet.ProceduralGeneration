namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWebGenerator : BaseGenerator<CosmicWeb, CosmicWebContext>
{
    private readonly IntergalacticMediumGenerator _intergalacticMediumGenerator;
    private readonly BaryonicFilamentGenerator _baryonicFilamentGenerator;
    private readonly DarkMatterFilamentGenerator _darkMatterFilamentGenerator;
    private readonly BaryonicMatterNodeGenerator _baryonicNodeGenerator;
    private readonly DarkMatterNodeGenerator _darkMatterNodeGenerator;
    private readonly BaryonicVoidGenerator _baryonicVoidGenerator;
    private readonly DarkMatterVoidGenerator _darkMatterVoidGenerator;
    private readonly BaryonicMatterSheetGenerator _baryonicSheetGenerator;
    private readonly DarkMatterSheetGenerator _darkMatterSheetGenerator;


    public override CosmicWeb Generate(CosmicWebContext context)
    {
        var cosmicWeb = new CosmicWeb();

        var heightMapImage= HeightmapUtil.LoadImage(config.HeightmapImageFile);

        if (config.GaussianSigma > 0f)
        {
            heightMapImage = HeightmapUtil.GaussianBlur(heightMapImage, config.GaussianSigma);
        }

        var heightMap = HeightmapUtil.ImageToHeightmap(heightMapImage);
        var volumeMap = HeightmapUtil.ExtrudeHeightmapToVolumeMap(heightMap, 1);
        var gradientMap = HeightmapUtil.VolumeMapToGradientMap(volumeMap);
        var averageIntensity = HeightmapUtil.GetAverageIntensity(heightMapImage);

        cosmicWeb.Topology = new CosmicTopology()
        {
            AverageIntensity = averageIntensity,
            Heightmap = heightMap,
            VolumeMap = volumeMap,
            GradientMap = gradientMap
        };

        Parallel.For(0, GetBaryonicFilamentCount(context, averageIntensity), i =>
        {
            var baryonicFilament = _baryonicFilamentGenerator.Generate(new BaryonicFilamentContext(cosmicWeb));
            cosmicWeb.BaryonicFilaments.Add(baryonicFilament);
        });

        Parallel.For(0, GetDarkMatterFilamentCount(context, averageIntensity), i =>
        {
            var darkMatterFilament = _darkMatterFilamentGenerator.Generate(new DarkMatterFilamentContext(cosmicWeb));
            cosmicWeb.DarkMatterFilaments.Add(darkMatterFilament);
        });

        Parallel.For(0, GetBaryonicNodeCount(context, averageIntensity), i =>
        {
            var baryonicNode = _baryonicNodeGenerator.Generate(new BaryonicNodeContext(cosmicWeb));
            cosmicWeb.BaryonicNodes.Add(baryonicNode);
        });

        Parallel.For(0, GetDarkMatterNodeCount(context, averageIntensity), i =>
        {
            var darkMatterNode = _darkMatterNodeGenerator.Generate(new DarkMatterNodeContext(cosmicWeb));
            cosmicWeb.DarkMatterNodes.Add(darkMatterNode);
        });

        Parallel.For(0, GetBaryonicVoidCount(context, averageIntensity), i =>
        {
            var baryonicVoid = _baryonicVoidGenerator.Generate(new BaryonicVoidContext(cosmicWeb));
            cosmicWeb.BaryonicVoids.Add(baryonicVoid);
        });

        Parallel.For(0, GetDarkMatterVoidCount(context, averageIntensity), i =>
        {
            var darkMatterVoid = _darkMatterVoidGenerator.Generate(new DarkMatterVoidContext(cosmicWeb));
            cosmicWeb.DarkMatterVoids.Add(darkMatterVoid);
        });

        Parallel.For(0, GetBaryonicSheetCount(context, averageIntensity), i =>
        {
            var baryonicSheet = _baryonicSheetGenerator.Generate(new BaryonicSheetContext(cosmicWeb));
            cosmicWeb.BaryonicSheets.Add(baryonicSheet);
        });

        Parallel.For(0, GetDarkMatterSheetCount(context, averageIntensity), i =>
        {
            var darkMatterSheet = _darkMatterSheetGenerator.Generate(new DarkMatterSheetContext(cosmicWeb));
            cosmicWeb.DarkMatterSheets.Add(darkMatterSheet);
        });

        var intergalacticMediumContext = new IntergalacticMediumContext();
        var imgTask = Task.Run(() => _intergalacticMediumGenerator.Generate(intergalacticMediumContext));

        Task.WaitAll(imgTask);

        cosmicWeb.IntergalacticMedium = imgTask.Result;

        PostProcess();

        return cosmicWeb;
    }

    private void PostProcess()
    {

    }

    private int GetBaryonicFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = 1000;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 200;
                break;
            case CurvatureType.Spherical:
                baseCount += 100;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 100;
                break;
        }

        baseCount += (int)(context.Age * config.BaryonicMatterFilamentAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.BaryonicMatterFilamentMassFactor) * (context.Size * config.BaryonicMatterFilamentSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.BaryonicMatterFilamentBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.BaryonicMatterFilamentDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.BaryonicMatterFilamentDarkEnergyPercentFactor));

        return baseCount;
    }

    private int GetDarkMatterFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = 1500;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 250;
                break;
            case CurvatureType.Spherical:
                baseCount += 150;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 150;
                break;
        }

        baseCount += (int)(context.Age * 12);
        baseCount = (int)(baseCount * (context.Mass / 1e30) * (context.Size / 1e9));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / 100);
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / 200);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / 100));

        return baseCount;
    }
    
    private int GetBaryonicNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = 300;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 50;
                break;
            case CurvatureType.Spherical:
                baseCount += 30;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 20;
                break;
        }

        baseCount += (int)(context.Age * 5);
        baseCount = (int)(baseCount * (context.Mass / 1e30) * (context.Size / 1e9));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / 100);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / 200));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / 100));

        return baseCount;
    }
    
    private int GetDarkMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = 500;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 60;
                break;
            case CurvatureType.Spherical:
                baseCount += 40;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 30;
                break;
        }

        baseCount += (int)(context.Age * 6);
        baseCount = (int)(baseCount * (context.Mass / 1e30) * (context.Size / 1e9));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / 100);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / 200));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / 100));

        return baseCount;
    }
    
    private int GetBaryonicVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = 1500;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 100;
                break;
            case CurvatureType.Spherical:
                baseCount -= 50;
                break;
            case CurvatureType.Hyperbolic:
                baseCount += 50;
                break;
        }

        baseCount += (int)(context.Age * 8);
        baseCount = (int)(baseCount * (context.Mass / 1e30) * (context.Size / 1e9));
        baseCount = (int)(baseCount * (context.ExpansionRate / config.BaselineExpansionRate));
        baseCount = (int)(baseCount * (config.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / 100));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / 150));

        return baseCount;
    }
    
    private int GetDarkMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = 1400;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 120;
                break;
            case CurvatureType.Spherical:
                baseCount -= 60;
                break;
            case CurvatureType.Hyperbolic:
                baseCount += 60;
                break;
        }
        baseCount += (int)(context.Age * 7);
        baseCount = (int)(baseCount * (context.Mass / 1e30) * (context.Size / 1e9));
        baseCount = (int)(baseCount * (context.ExpansionRate / config.BaselineExpansionRate));
        baseCount = (int)(baseCount * (config.BaselineCosmicMicrowaveBackground/ context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / 100));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / 150));

        return baseCount;
    }
    
    private int GetBaryonicSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = 300;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 40;
                break;
            case CurvatureType.Spherical:
                baseCount += 20;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 20;
                break;
        }

        baseCount += (int)(context.Age * 5);
        baseCount = (int)(baseCount * (context.Mass / 1e30) * (context.Size / 1e9));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / 100);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / 150));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / 100));

        return baseCount;
    }
    
    private int GetDarkMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = 500;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 50;
                break;
            case CurvatureType.Spherical:
                baseCount += 30;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 30;
                break;
        }

        baseCount += (int)(context.Age * 7);
        baseCount = (int)(baseCount * (context.Mass / 1e30) * (context.Size / 1e9));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / 100);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / 200));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / 100));

        return baseCount;
    }
    
    public CosmicWebGenerator(GeneratorConfig config) : base(config)
    {
        _intergalacticMediumGenerator = new IntergalacticMediumGenerator(config);
        _baryonicFilamentGenerator = new BaryonicFilamentGenerator(config);
        _darkMatterFilamentGenerator = new DarkMatterFilamentGenerator(config);
        _baryonicNodeGenerator = new BaryonicMatterNodeGenerator(config);
        _darkMatterNodeGenerator = new DarkMatterNodeGenerator(config);
        _baryonicVoidGenerator = new BaryonicVoidGenerator(config);
        _darkMatterVoidGenerator = new DarkMatterVoidGenerator(config);
        _baryonicSheetGenerator = new BaryonicMatterSheetGenerator(config);
        _darkMatterSheetGenerator = new DarkMatterSheetGenerator(config);
    }
}