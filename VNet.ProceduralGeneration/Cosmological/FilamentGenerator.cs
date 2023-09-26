namespace VNet.ProceduralGeneration.Cosmological;

public class FilamentGenerator : IGeneratable<Filament, FilamentContext>
{
    private readonly SuperclusterGenerator _superclusterGenerator = new SuperclusterGenerator();

    public Filament Generate(FilamentContext context)
    {
        var filament = new Filament
        {

        };

        int superclusterCount = 0;
        for (int i = 0; i < superclusterCount; i++)
        {
            filament.Superclusters.Add(_superclusterGenerator.Generate(new SuperclusterContext()));
        }

        return filament;
    }
}