namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWebGenerator : BaseGenerator<CosmicWeb, CosmicWebContext>
{
    private readonly FilamentGenerator _filamentGenerator;


    public override CosmicWeb Generate(CosmicWebContext context)
    {
        var cosmicWeb = new CosmicWeb
        {

        };

        int filamentCount = 0;
        for (int i = 0; i < filamentCount; i++)
        {
            cosmicWeb.Filaments.Add(_filamentGenerator.Generate(new FilamentContext()));
        }

        return cosmicWeb;
    }

    public int GetFilamentCount(CosmicWebContext context)
    {
        const int BASE_COUNT = 100;

        // Use a function of the context size. This can be a simple linear scale or other function. 
        // For simplicity, assume the size value will be between 0 and 1000 (or whatever maximum makes sense in your application).
        double sizeFactor = Math.Max(0.1, context.Size / 1000.0); // Ensuring a minimum scaling factor

        // Age might influence the filament count. Using a simple function can ensure it's not zero.
        double ageFactor = Math.Max(0.1, context.Age / 100.0); // Here we're considering a Universe age range up to 100 units.

        double energyFactor = Math.Max(0.1, 1 - context.DarkEnergy / config.MaxDarkEnergyValue); // Assuming DarkEnergy value is between 0 and MAX_DARK_ENERGY_VALUE.
        double expansionFactor = Math.Max(0.1, 1 - context.ExpansionRate / config.MaxExpansionRate); // Assuming ExpansionRate is between 0 and MAX_EXPANSION_RATE.

        // Use all the factors to calculate the final count
        int count = (int)(BASE_COUNT * sizeFactor * ageFactor * energyFactor * expansionFactor);

        double randomFactor = 1 + (RandomValue() * 0.2 - 0.1); // Random value between -10% and +10%
        count = (int)(count * randomFactor);

        return count;
    }

    public CosmicWebGenerator(GeneratorConfig config) : base(config)
    {
        _filamentGenerator = new FilamentGenerator(config);
    }
}