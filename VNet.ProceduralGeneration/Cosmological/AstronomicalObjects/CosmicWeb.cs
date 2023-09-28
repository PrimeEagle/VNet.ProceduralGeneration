using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWeb : AstronomicalObject
{
    public CosmicWebTopology Topology { get; set; }
    public IntergalacticMedium IntergalacticMedium { get; set; }
    public ConcurrentBag<BaryonicMatterFilament> BaryonicFilaments { get; set; } = new ConcurrentBag<BaryonicMatterFilament>();
    public ConcurrentBag<DarkMatterFilament> DarkMatterFilaments { get; set; } = new ConcurrentBag<DarkMatterFilament>();
    public ConcurrentBag<BaryonicMatterNode> BaryonicNodes { get; set; } = new ConcurrentBag<BaryonicMatterNode>();
    public ConcurrentBag<DarkMatterNode> DarkMatterNodes { get; set; } = new ConcurrentBag<DarkMatterNode>();
    public ConcurrentBag<BaryonicMatterVoid> BaryonicVoids { get; set; } = new ConcurrentBag<BaryonicMatterVoid>();
    public ConcurrentBag<DarkMatterVoid> DarkMatterVoids { get; set; } = new ConcurrentBag<DarkMatterVoid>();
    public ConcurrentBag<BaryonicMatterSheet> BaryonicSheets { get; set; } = new ConcurrentBag<BaryonicMatterSheet>();
    public ConcurrentBag<DarkMatterSheet> DarkMatterSheets { get; set; } = new ConcurrentBag<DarkMatterSheet>();
}