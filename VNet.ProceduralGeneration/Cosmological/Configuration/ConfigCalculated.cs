namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class ConfigCalculated
    {
        public GeneratorConfig Config { get; init; }
        public float AverageDim
        {
            get { return CalculateAverageDim(); }
        }
        public float TopologyBaryonicMatterNodeSeedMergeDistanceThreshold
        {
            get
            {
                return Config.Constants.TopologyBaryonicMatterNodeSeedMergeDistanceThresholdFactor * this.AverageDim;
            }
        }
        public float TopologyBaryonicMatterNodeSeedMinDistanceThreshold
        {
            get
            {
                return this.TopologyBaryonicMatterNodeSeedMergeDistanceThreshold * Config.Constants.TopologyBaryonicMatterNodeSeedMinDistanceThresholdFactor;
            }
        }
        public float TopologyDarkMatterNodeSeedMergeDistanceThreshold
        {
            get
            {
                return Config.Constants.TopologyDarkMatterNodeSeedMergeDistanceThresholdFactor * this.AverageDim;
            }
        }
        public float TopologyDarkMatterNodeSeedMinDistanceThreshold
        {
            get
            {
                return this.TopologyDarkMatterNodeSeedMergeDistanceThreshold * Config.Constants.TopologyDarkMatterNodeSeedMinDistanceThresholdFactor;
            }
        }



        public ConfigCalculated(GeneratorConfig config)
        {
            Config = config;
        }
        private float CalculateAverageDim()
        {
            return (Config.DimX + Config.DimY + Config.DimZ) / 3;
        }
    }
}