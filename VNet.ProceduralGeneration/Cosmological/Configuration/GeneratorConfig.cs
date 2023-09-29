using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class GeneratorConfig
    {
        public ConfigConstants Constants { get; init; }
        public ConfigCalculated Calculated { get; init; }
        public ConfigAstronomicalObjects AstronomicalObjects { get; init; }
        public ConfigTheoreticalAstronomicalObjects TheoreticalAstronomicalObjects { get; init; }
        public float DimX { get; set; }
        public float DimY { get; set; }
        public float DimZ { get; set; }
        public IRandomGenerationAlgorithm RandomGenerator { get; set; }


        public GeneratorConfig(int dimX, int dimY, int dimZ)
        {
            this.DimX = dimX;
            this.DimY = dimY;
            this.DimZ = dimZ;
            this.RandomGenerator = new DotNetGenerator();
            this.Constants = new ConfigConstants();
            this.Calculated = new ConfigCalculated(this);
            this.AstronomicalObjects = new ConfigAstronomicalObjects();
            this.TheoreticalAstronomicalObjects = new ConfigTheoreticalAstronomicalObjects();
        }

        public GeneratorConfig(int dimX, int dimY, int dimZ, IRandomGenerationAlgorithm random)
        {
            this.DimX = dimX;
            this.DimY = dimY;
            this.DimZ = dimZ;
            this.RandomGenerator = random;
            this.Constants = new ConfigConstants();
            this.Calculated = new ConfigCalculated(this);
            this.AstronomicalObjects = new ConfigAstronomicalObjects();
            this.TheoreticalAstronomicalObjects = new ConfigTheoreticalAstronomicalObjects();
        }
    }
}