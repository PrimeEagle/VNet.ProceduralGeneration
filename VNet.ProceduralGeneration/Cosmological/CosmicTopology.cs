using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological
{
    public class CosmicTopology
    {
        public float AverageIntensity { get; set; }
        public float MaxGradientMagnitude { get; set; }
        public float[,] Heightmap { get; set; }
        public float[,,] VolumeMap { get; set; }
        public Vector3[,,] GradientMap { get; set; }
    }
}