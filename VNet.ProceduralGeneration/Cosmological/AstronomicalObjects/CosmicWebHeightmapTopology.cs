using System.Numerics;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class CosmicWebHeightmapTopology
{
    public float AverageIntensity { get; set; }
    public float MaxGradientMagnitude { get; set; }
    public float[,] Heightmap { get; set; }
    public float[,,] VolumeMap { get; set; }
    public Vector3[,,] GradientMap { get; set; }
}