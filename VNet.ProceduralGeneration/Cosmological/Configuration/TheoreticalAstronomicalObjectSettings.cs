using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects.Theoretical;
namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class TheoreticalAstronomicalObjectSettings
    {
        public BraneSettings Brane { get; init; }
        public CosmicBubbleSettings CosmicBubble { get; init; }
        public CosmicDustLaneSettings CosmicDustLane { get; init; }
        public CosmicStringSettings CosmicString { get; init; }
        public CosmicTopologicalDefectSettings CosmicTopologicalDefect { get; init; }
        public CosmicTornadoSettings CosmicTornado { get; init; }
        public CuspCatastropheSettings CuspCatastrophe { get; init; }
        public DarkMatterFilamentSettings DarkMatterFilament { get; init; }
        public DarkMatterFilamentStructureSettings DarkMatterFilamentStructure { get; init; }
        public DarkMatterNodeSettings DarkMatterNode { get; init; }
        public DarkMatterNodeStructureSettings DarkMatterNodeStructure { get; init; }
        public DarkMatterSheetSettings DarkMatterSheet { get; init; }
        public DarkMatterSheetStructureSettings DarkMatterSheetStructure { get; init; }
        public DarkMatterVoidSettings DarkMatterVoid { get; init; }
        public DarkMatterVoidStructureSettings DarkMatterVoidStructure { get; init; }
        public DarkStarSettings DarkStar { get; init; }
        public DomainWallSettings DomainWall { get; init; }
        public DysonSphereSettings DysonSphere { get; init; }
        public FermiBubbleSettings FermiBubble { get; init; }
        public FuzzballSettings Fuzzball { get; init; }
        public KugelblitzSettings Kugelblitz { get; init; }
        public MagnetarSettings Magnetar { get; init; }
        public MonopoleSettings Monopole { get; init; }
        public NakedSingularitySettings NakedSingularity { get; init; }
        public PlanckStarSettings PlanckStar { get; init; }
        public PreonStarSettings PreonStar { get; init; }
        public PrimordialBlackHoleSettings PrimordialBlackHole { get; init; }
        public QuantumBlackHoleSettings QuantumBlackHole { get; init; }
        public QuarkStarSettings QuarkStar { get; init; }
        public SpatialWormholeSettings SpatialWormhole { get; init; }
        public TachyonicFieldSettings TachyonicField { get; init; }
        public TemporalWormholeSettings TemporalWormhole { get; init; }
        public TransdimensionalWormholeSettings TransdimensionalWormhole { get; init; }
        public WhiteHoleSettings WhiteHole { get; init; }




        public TheoreticalAstronomicalObjectSettings()
        {
            Brane = new BraneSettings();
            CosmicBubble = new CosmicBubbleSettings();
            CosmicDustLane = new CosmicDustLaneSettings();
            CosmicString = new CosmicStringSettings();
            CosmicTopologicalDefect = new CosmicTopologicalDefectSettings();
            CosmicTornado = new CosmicTornadoSettings();
            CuspCatastrophe = new CuspCatastropheSettings();
            DarkMatterFilament = new DarkMatterFilamentSettings();
            DarkMatterFilamentStructure = new DarkMatterFilamentStructureSettings();
            DarkMatterNode = new DarkMatterNodeSettings();
            DarkMatterNodeStructure = new DarkMatterNodeStructureSettings();
            DarkMatterSheet = new DarkMatterSheetSettings();
            DarkMatterSheetStructure = new DarkMatterSheetStructureSettings();
            DarkMatterVoid = new DarkMatterVoidSettings();
            DarkMatterVoidStructure = new DarkMatterVoidStructureSettings();
            DarkStar = new DarkStarSettings();
            DomainWall = new DomainWallSettings();
            DysonSphere = new DysonSphereSettings();
            FermiBubble = new FermiBubbleSettings();
            Fuzzball = new FuzzballSettings();
            Kugelblitz = new KugelblitzSettings();
            Magnetar = new MagnetarSettings();
            Monopole = new MonopoleSettings();
            NakedSingularity = new NakedSingularitySettings();
            PlanckStar = new PlanckStarSettings();
            PreonStar = new PreonStarSettings();
            PrimordialBlackHole = new PrimordialBlackHoleSettings();
            QuantumBlackHole = new QuantumBlackHoleSettings();
            QuarkStar = new QuarkStarSettings();
            SpatialWormhole = new SpatialWormholeSettings();
            TachyonicField = new TachyonicFieldSettings();
            TemporalWormhole = new TemporalWormholeSettings();
            TransdimensionalWormhole = new TransdimensionalWormholeSettings();
            WhiteHole = new WhiteHoleSettings();
        }
    }
}