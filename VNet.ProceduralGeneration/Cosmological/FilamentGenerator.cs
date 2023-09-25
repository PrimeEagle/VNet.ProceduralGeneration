namespace VNet.ProceduralGeneration.Cosmological;

public class FilamentGenerator : IGeneratable<Filament, FilamentContext>
{
    private readonly SuperclusterGenerator _superclusterGenerator = new SuperclusterGenerator();

    public Filament Generate(FilamentContext context)
    {
        var filament = new Filament
        {
            // ... Generate properties specific to Filament
        };

        // Generate Superclusters for this Filament
        int superclusterCount = 0/* determine count based on some logic */;
        for (int i = 0; i < superclusterCount; i++)
        {
            filament.Superclusters.Add(_superclusterGenerator.Generate());
        }

        return filament;
    }
}