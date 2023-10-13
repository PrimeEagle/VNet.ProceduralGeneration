using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class CosmicWeb : AstronomicalObjectGroup
{
    public CosmicWebHeightmapTopology HeightmapTopology { get; set; }
    public IntergalacticMedium IntergalacticMedium { get; set; }
    public List<BaryonicMatterNode> BaryonicMatterNodes { get; set; } = new();
    public List<BaryonicMatterFilament> BaryonicMatterFilaments { get; set; } = new();
    public List<BaryonicMatterSheet> BaryonicMatterSheets { get; set; } = new();
    public List<BaryonicMatterVoid> BaryonicMatterVoids { get; set; } = new();
    public List<DarkMatterNode> DarkMatterNodes { get; set; } = new();
    public List<DarkMatterFilament> DarkMatterFilaments { get; set; } = new();
    public List<DarkMatterSheet> DarkMatterSheets { get; set; } = new();
    public List<DarkMatterVoid> DarkMatterVoids { get; set; } = new();

    internal override void AssignChildren()
    {
        Children.Add(IntergalacticMedium);
        Children.AddRange(BaryonicMatterNodes);
        Children.AddRange(BaryonicMatterFilaments);
        Children.AddRange(BaryonicMatterSheets);
        Children.AddRange(BaryonicMatterVoids);
        Children.AddRange(DarkMatterNodes);
        Children.AddRange(DarkMatterFilaments);
        Children.AddRange(DarkMatterSheets);
        Children.AddRange(DarkMatterVoids);
    }
}