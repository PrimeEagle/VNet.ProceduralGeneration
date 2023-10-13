using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological;

internal static class Util
{
    internal static Vector3 GetRandomOffset(float maxOffset)
    {
        var random = new Random();
        var offsetX = (float) (random.NextDouble() * 2 - 1) * maxOffset;
        var offsetY = (float) (random.NextDouble() * 2 - 1) * maxOffset;
        var offsetZ = (float) (random.NextDouble() * 2 - 1) * maxOffset;

        return new Vector3(offsetX, offsetY, offsetZ);
    }
}