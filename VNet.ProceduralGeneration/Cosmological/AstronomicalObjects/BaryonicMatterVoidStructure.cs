using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

// ReSharper disable CollectionNeverUpdated.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class BaryonicMatterVoidStructure : VoidStructure
{
    public float VolumeCoveredByPercent { get; set; }
    public float OverlappingPercent { get; set; }
    public List<BaryonicMatterVoid> BaryonicMatterVoids { get; set; }
}