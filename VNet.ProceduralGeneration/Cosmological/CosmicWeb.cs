using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWeb : AstronomicalObject
{
    public CosmicTopology Topology { get; set; }
    public IntergalacticMedium IntergalacticMedium { get; set; }
    public ConcurrentBag<BaryonicFilament> BaryonicFilaments { get; set; } = new ConcurrentBag<BaryonicFilament>();
    public ConcurrentBag<DarkMatterFilament> DarkMatterFilaments { get; set; } = new ConcurrentBag<DarkMatterFilament>();
    public ConcurrentBag<BaryonicMatterNode> BaryonicNodes { get; set; } = new ConcurrentBag<BaryonicMatterNode>();
    public ConcurrentBag<DarkMatterNode> DarkMatterNodes { get; set; } = new ConcurrentBag<DarkMatterNode>();
    public ConcurrentBag<BaryonicVoid> BaryonicVoids { get; set; } = new ConcurrentBag<BaryonicVoid>();
    public ConcurrentBag<DarkMatterVoid> DarkMatterVoids { get; set; } = new ConcurrentBag<DarkMatterVoid>();
    public ConcurrentBag<BaryonicSheet> BaryonicSheets { get; set; } = new ConcurrentBag<BaryonicSheet>();
    public ConcurrentBag<DarkMatterSheet> DarkMatterSheets { get; set; } = new ConcurrentBag<DarkMatterSheet>();
}