
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
// ReSharper disable CollectionNeverUpdated.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class CosmicWeb : AstronomicalObjectGroup
{
    public CosmicWebHeightmapTopology HeightmapTopology { get; set; }
    public IntergalacticMedium IntergalacticMedium { get; set; }
    public BaryonicMatterVoidStructure BaryonicMatterVoidStructure { get; set; }
    public BaryonicMatterFilamentStructure BaryonicMatterFilamentStructure { get; set; }
    public BaryonicMatterSheetStructure BaryonicMatterSheetStructure { get; set; }
    public BaryonicMatterNodeStructure BaryonicMatterNodeStructure { get; set; }
    public DarkMatterVoidStructure DarkMatterVoidStructure { get; set; }
    public DarkMatterFilamentStructure DarkMatterFilamentStructure { get; set; }
    public DarkMatterSheetStructure DarkMatterSheetStructure { get; set; }
    public DarkMatterNodeStructure DarkMatterNodeStructure { get; set; }

    public CosmicWeb() { }
}
