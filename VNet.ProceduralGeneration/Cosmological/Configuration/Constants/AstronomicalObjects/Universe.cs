using VNet.Configuration;

// ReSharper disable CheckNamespace
namespace VNet.ProceduralGeneration.Cosmological.Configuration;


internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static partial class Objects
        {
            internal static class Universe
            {
                internal static Range<float> InflationRange { get; } = new Range<float>(5e9f, 30e9f);
            }
        }
    }
}