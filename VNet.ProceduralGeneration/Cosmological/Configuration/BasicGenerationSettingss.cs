using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BasicGenerationSettings : ISettings
    {
        public float DimensionX { get; set; }
        public float DimensionY { get; set; }
        public float DimensionZ { get; set; }
        public double MinDarkEnergyPercent { get; set; }
        public double MaxDarkEnergyPercent { get; set; }
        public double MinDarkMatterPercent { get; set; }
        public double MaxDarkMatterPercent { get; set; }
        public double MinBaryonicMatterPercent { get; set; }
        public double MaxBaryonicMatterPercent { get; set; }
        public float MinUniverseAge { get; set; }
        public float MaxUniverseAge { get; set; }
        public string HeightmapImageFile { get; set; }
        public int BaryonicMatterNodeBaseCount { get; set; }
        public int BaryonicMatterFilamentBaseCount { get; set; }
        public int BaryonicMatterSheetBaseCount { get; set; }
        public int BaryonicMatterVoidBaseCount { get; set; }
        public int DarkMatterNodeBaseCount { get; set; }
        public int DarkMatterFilamentBaseCount { get; set; }
        public int DarkMatterSheetBaseCount { get; set; }
        public int DarkMatterVoidBaseCount { get; set; }
        public float AverageDimension
        {
            get { return CalculateAverageDim(); }
        }
        public float TopologyBaryonicMatterNodeSeedMergeDistanceThreshold
        {
            get
            {
                return ConfigConstants.TopologyBaryonicMatterNodeSeedMergeDistanceThresholdFactor * this.AverageDimension;
            }
        }
        public float TopologyBaryonicMatterNodeSeedMinDistanceThreshold
        {
            get
            {
                return this.TopologyBaryonicMatterNodeSeedMergeDistanceThreshold * ConfigConstants.TopologyBaryonicMatterNodeSeedMinDistanceThresholdFactor;
            }
        }
        public float TopologyDarkMatterNodeSeedMergeDistanceThreshold
        {
            get
            {
                return ConfigConstants.TopologyDarkMatterNodeSeedMergeDistanceThresholdFactor * this.AverageDimension;
            }
        }
        public float TopologyDarkMatterNodeSeedMinDistanceThreshold
        {
            get
            {
                return this.TopologyDarkMatterNodeSeedMergeDistanceThreshold * ConfigConstants.TopologyDarkMatterNodeSeedMinDistanceThresholdFactor;
            }
        }




        public BasicGenerationSettings()
        {
            this.DimensionX = ConfigConstants.DimensionX;
            this.DimensionY = ConfigConstants.DimensionY;
            this.DimensionZ = ConfigConstants.DimensionZ;
            this.MinDarkEnergyPercent = ConfigConstants.DefaultMinDarkEnergyPercent;
            this.MaxDarkEnergyPercent = ConfigConstants.DefaultMaxDarkEnergyPercent;
            this.MinDarkMatterPercent = ConfigConstants.DefaultMinDarkMatterPercent;
            this.MaxDarkMatterPercent = ConfigConstants.DefaultMaxDarkMatterPercent;
            this.MinBaryonicMatterPercent = ConfigConstants.DefaultMinBaryonicMatterPercent;
            this.MaxBaryonicMatterPercent = ConfigConstants.DefaultMaxBaryonicMatterPercent;
            this.MinUniverseAge = ConfigConstants.DefaultMinUniverseAge;
            this.MaxUniverseAge = ConfigConstants.DefaultMaxUniverseAge;
            this.BaryonicMatterFilamentBaseCount = ConfigConstants.BaryonicMatterFilamentBaseCount;
            this.DarkMatterFilamentBaseCount = ConfigConstants.DarkMatterFilamentBaseCount;
            this.BaryonicMatterNodeBaseCount = ConfigConstants.BaryonicMatterNodeBaseCount;
            this.DarkMatterNodeBaseCount = ConfigConstants.DarkMatterNodeBaseCount;
            this.BaryonicMatterSheetBaseCount = ConfigConstants.BaryonicMatterSheetBaseCount;
            this.DarkMatterSheetBaseCount = ConfigConstants.DarkMatterSheetBaseCount;
            this.BaryonicMatterVoidBaseCount = ConfigConstants.BaryonicMatterVoidBaseCount;
            this.DarkMatterVoidBaseCount = ConfigConstants.DarkMatterVoidBaseCount;
        }

        private float CalculateAverageDim()
        {
            return (DimensionX + DimensionY + DimensionZ) / 3;
        }
    }
}