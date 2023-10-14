using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
// ReSharper disable CollectionNeverUpdated.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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
}