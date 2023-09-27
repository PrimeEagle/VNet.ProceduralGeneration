namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWeb : AstronomicalObject
{
    public IntergalacticMedium IntergalacticMedium { get; set; }
    public List<BaryonicFilament> BaryonicFilaments { get; set; } = new List<BaryonicFilament>();
    public List<DarkMatterFilament> DarkMatterFilaments { get; set; } = new List<DarkMatterFilament>();
    public List<BaryonicNode> BaryonicNodes { get; set; } = new List<BaryonicNode>();
    public List<DarkMatterNode> DarkMatterNodes { get; set; } = new List<DarkMatterNode>();
    public List<BaryonicVoid> BaryonicVoids { get; set; } = new List<BaryonicVoid>();
    public List<DarkMatterVoid> DarkMatterVoids { get; set; } = new List<DarkMatterVoid>();
    public List<BaryonicSheet> BaryonicSheets { get; set; } = new List<BaryonicSheet>();
    public List<DarkMatterSheet> DarkMatterSheets { get; set; } = new List<DarkMatterSheet>();
}