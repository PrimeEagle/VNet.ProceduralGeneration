namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWebGenerator : BaseGenerator<CosmicWeb, CosmicWebContext>
{
    private readonly IntergalacticMediumGenerator _intergalacticMediumGenerator;
    private readonly BaryonicMatterFilamentGenerator _baryonicFilamentGenerator;
    private readonly DarkMatterFilamentGenerator _darkMatterFilamentGenerator;
    private readonly BaryonicMatterNodeGenerator _baryonicNodeGenerator;
    private readonly DarkMatterNodeGenerator _darkMatterNodeGenerator;
    private readonly BaryonicMatterVoidGenerator _baryonicVoidGenerator;
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

        Parallel.For(0, GetBaryonicMatterFilamentCount(context, averageIntensity), i =>
        {
            var baryonicFilament = _baryonicFilamentGenerator.Generate(new BaryonicMatterFilamentContext(cosmicWeb));
            cosmicWeb.BaryonicFilaments.Add(baryonicFilament);
        });

        Parallel.For(0, GetDarkMatterFilamentCount(context, averageIntensity), i =>
        {
            var darkMatterFilament = _darkMatterFilamentGenerator.Generate(new DarkMatterFilamentContext(cosmicWeb));
            cosmicWeb.DarkMatterFilaments.Add(darkMatterFilament);
        });

        Parallel.For(0, GetBaryonicMatterNodeCount(context, averageIntensity), i =>
        {
            var baryonicNode = _baryonicNodeGenerator.Generate(new BaryonicMatterNodeContext(cosmicWeb));
            cosmicWeb.BaryonicNodes.Add(baryonicNode);
        });

        Parallel.For(0, GetDarkMatterNodeCount(context, averageIntensity), i =>
        {
            var darkMatterNode = _darkMatterNodeGenerator.Generate(new DarkMatterNodeContext(cosmicWeb));
            cosmicWeb.DarkMatterNodes.Add(darkMatterNode);
        });

        Parallel.For(0, GetBaryonicMatterVoidCount(context, averageIntensity), i =>
        {
            var baryonicVoid = _baryonicVoidGenerator.Generate(new BaryonicMatterVoidContext(cosmicWeb));
            cosmicWeb.BaryonicVoids.Add(baryonicVoid);
        });

        Parallel.For(0, GetDarkMatterVoidCount(context, averageIntensity), i =>
        {
            var darkMatterVoid = _darkMatterVoidGenerator.Generate(new DarkMatterVoidContext(cosmicWeb));
            cosmicWeb.DarkMatterVoids.Add(darkMatterVoid);
        });

        Parallel.For(0, GetBaryonicMatterSheetCount(context, averageIntensity), i =>
        {
            var baryonicSheet = _baryonicSheetGenerator.Generate(new BaryonicMatterSheetContext(cosmicWeb));
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

    private int GetBaryonicMatterFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.BaryonicMatterFilamentBaseCount;

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
        var baseCount = config.DarkMatterFilamentBaseCount;

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

        baseCount += (int)(context.Age * config.DarkMatterFilamentAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.DarkMatterFilamentMassFactor) * (context.Size * config.DarkMatterFilamentSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.DarkMatterFilamentDarkMatterPercentFactor);
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.DarkMatterFilamentBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.DarkMatterFilamentDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetBaryonicMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.BaryonicMatterNodeBaseCount;

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

        baseCount += (int)(context.Age * config.BaryonicMatterNodeAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.BaryonicMatterNodeMassFactor) * (context.Size * config.BaryonicMatterNodeSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.BaryonicMatterNodeBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / config.BaryonicMatterNodeDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.BaryonicMatterNodeDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetDarkMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.DarkMatterNodeBaseCount;

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

        baseCount += (int)(context.Age * config.DarkMatterNodeAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.DarkMatterNodeMassFactor) * (context.Size * config.DarkMatterNodeSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.DarkMatterNodeDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / config.DarkMatterNodeBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.DarkMatterNodeDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetBaryonicMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.BaryonicMatterVoidBaseCount;

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

        baseCount += (int)(context.Age * config.BaryonicMatterVoidAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.BaryonicMatterVoidAgeFactor) * (context.Size * config.BaryonicMatterVoidSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / config.BaselineExpansionRate));
        baseCount = (int)(baseCount * (config.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / config.BaryonicMatterVoidBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / config.BaryonicMatterVoidDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetDarkMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.DarkMatterVoidBaseCount;

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
        baseCount += (int)(context.Age * config.DarkMatterVoidAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.DarkMatterVoidMassFactor) * (context.Size * config.DarkMatterVoidSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / config.BaselineExpansionRate));
        baseCount = (int)(baseCount * (config.BaselineCosmicMicrowaveBackground/ context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / config.DarkMatterVoidDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / config.DarkMatterVoidDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetBaryonicMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.BaryonicMatterSheetBaseCount;

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

        baseCount += (int)(context.Age * config.BaryonicMatterSheetAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.BaryonicMatterSheetMassFactor) * (context.Size * config.BaryonicMatterSheetSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.BaryonicMatterSheetBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / config.BaryonicMatterSheetDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.BaryonicMatterSheetDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetDarkMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.DarkMatterSheetBaseCount;

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

        baseCount += (int)(context.Age * config.DarkMatterSheetAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.DarkMatterSheetMassFactor) * (context.Size * config.DarkMatterSheetSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.DarkMatterSheetDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / config.DarkMatterSheetBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.DarkMatterSheetDarkEnergyPercentFactor));

        return baseCount;
    }
    
    public CosmicWebGenerator(GeneratorConfig config) : base(config)
    {
        _intergalacticMediumGenerator = new IntergalacticMediumGenerator(config);
        _baryonicFilamentGenerator = new BaryonicMatterFilamentGenerator(config);
        _darkMatterFilamentGenerator = new DarkMatterFilamentGenerator(config);
        _baryonicNodeGenerator = new BaryonicMatterNodeGenerator(config);
        _darkMatterNodeGenerator = new DarkMatterNodeGenerator(config);
        _baryonicVoidGenerator = new BaryonicMatterVoidGenerator(config);
        _darkMatterVoidGenerator = new DarkMatterVoidGenerator(config);
        _baryonicSheetGenerator = new BaryonicMatterSheetGenerator(config);
        _darkMatterSheetGenerator = new DarkMatterSheetGenerator(config);
    }
}