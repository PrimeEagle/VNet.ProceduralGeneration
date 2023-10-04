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

    internal override void AssignChildren()
    {
        this.Children.Add(this.IntergalacticMedium);
        this.Children.AddRange(this.BaryonicMatterNodes);
        this.Children.AddRange(this.BaryonicMatterFilaments);
        this.Children.AddRange(this.BaryonicMatterSheets);
        this.Children.AddRange(this.BaryonicMatterVoids);
        this.Children.AddRange(this.DarkMatterNodes);
        this.Children.AddRange(this.DarkMatterFilaments);
        this.Children.AddRange(this.DarkMatterSheets);
        this.Children.AddRange(this.DarkMatterVoids);
    }
}