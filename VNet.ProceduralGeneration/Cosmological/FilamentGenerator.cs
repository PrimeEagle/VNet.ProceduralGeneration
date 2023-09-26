namespace VNet.ProceduralGeneration.Cosmological;

public class FilamentGenerator : BaseGenerator<Filament, FilamentContext>
{
    private readonly SuperclusterGenerator _superclusterGenerator;


    public override Filament Generate(FilamentContext context)
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

    public FilamentGenerator(GeneratorConfig config) : base(config)
    {
        _superclusterGenerator = new SuperclusterGenerator(config);
    }
}