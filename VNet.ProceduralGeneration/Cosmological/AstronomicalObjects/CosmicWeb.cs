namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWeb : AstronomicalObject
{
    public CosmicWebTopology Topology { get; set; }
    public IntergalacticMedium IntergalacticMedium { get; set; }
    public List<BaryonicMatterNode> BaryonicMatterNodes { get; set; } = new List<BaryonicMatterNode>(); 
    public List<BaryonicMatterFilament> BaryonicMatterFilaments { get; set; } = new List<BaryonicMatterFilament>();
    public List<BaryonicMatterSheet> BaryonicMatterSheets { get; set; } = new List<BaryonicMatterSheet>();
    public List<BaryonicMatterVoid> BaryonicMatterVoids { get; set; } = new List<BaryonicMatterVoid>();
    public List<DarkMatterNode> DarkMatterNodes { get; set; } = new List<DarkMatterNode>(); 
    public List<DarkMatterFilament> DarkMatterFilaments { get; set; } = new List<DarkMatterFilament>();
    public List<DarkMatterSheet> DarkMatterSheets { get; set; } = new List<DarkMatterSheet>();
    public List<DarkMatterVoid> DarkMatterVoids { get; set; } = new List<DarkMatterVoid>();
}