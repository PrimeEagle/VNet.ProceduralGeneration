namespace VNet.ProceduralGeneration.Cosmological.Enum
{
    public enum ParallelismLevel
    {
        Level0,  // Single-threaded, no concurrency.
        Level1,  // Highest level of parallelism, used for top-level generator tasks.
        Level2,  // Reduced parallelism for second-level generator tasks.
        Level3,  // Reduced parallelism for third-level generator tasks.
        Level4   // Lowest level of parallelism, used for bottom-level generator tasks.
    }
}
