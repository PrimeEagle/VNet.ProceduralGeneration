namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class CosmicWeb : AstronomicalObject
{
    public CosmicWebTopology Topology { get; set; }
    public IntergalacticMedium IntergalacticMedium { get; set; }
    public List<BaryonicMatterNode> BaryonicMatterNodes { get; set; } = new(); 
    public List<BaryonicMatterFilament> BaryonicMatterFilaments { get; set; } = new();
    public List<BaryonicMatterSheet> BaryonicMatterSheets { get; set; } = new();
    public List<BaryonicMatterVoid> BaryonicMatterVoids { get; set; } = new();
    public List<DarkMatterNode> DarkMatterNodes { get; set; } = new(); 
    public List<DarkMatterFilament> DarkMatterFilaments { get; set; } = new();
    public List<DarkMatterSheet> DarkMatterSheets { get; set; } = new();
    public List<DarkMatterVoid> DarkMatterVoids { get; set; } = new();
}