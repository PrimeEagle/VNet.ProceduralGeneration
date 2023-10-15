using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;


namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class AstronomicalObjectSettings : ISettings
    {
        public TheoreticalAstronomicalObjectSettings Theoretical { get; init; }


        public AccretionDiskSettings AccretionDisk { get; init; }
        public AsteroidSettings Asteroid { get; init; }
        public AsteroidBeltSettings AsteroidBelt { get; init; }
        public BaryonicMatterFilamentSettings BaryonicMatterFilament { get; init; }
        public BaryonicMatterFilamentStructureSettings BaryonicMatterFilamentStructure { get; init; }
        public BaryonicMatterNodeSettings BaryonicMatterNode { get; init; }
        public BaryonicMatterNodeStructureSettings BaryonicMatterNodeStructure { get; init; }
        public BaryonicMatterSheetSettings BaryonicMatterSheet { get; init; }
        public BaryonicMatterSheetStructureSettings BaryonicMatterSheetStructure { get; init; }
        public BaryonicMatterVoidSettings BaryonicMatterVoid { get; init; }
        public BaryonicMatterVoidStructureSettings BaryonicMatterVoidStructure { get; init; }
        public BlackHoleSettings BlackHole { get; init; }
        public CometSettings Comet { get; init; }
        public CosmicWebSettings CosmicWeb { get; init; }
        public CubewanoSettings Cubewano { get; init; }
        public DebrisDiskSettings DebrisDisk { get; init; }
        public GalaxySettings Galaxy { get; init; }
        public GalaxyClusterSettings GalaxyCluster { get; init; }
        public GalaxyGroupSettings GalaxyGroup { get; init; }
        public GammaRayBurstSettings GammaRayBurst { get; init; }
        public IntergalacticMediumSettings IntergalacticMedium { get; init; }
        public JumboSettings Jumbo { get; init; }
        public LargeQuasarGroupSettings LargeQuasarGroup { get; init; }
        public MoonSettings Moon { get; init; }
        public NebulaSettings Nebula { get; init; }
        public NeutronStarSettings NeutronStar { get; init; }
        public NovaSettings Nova { get; init; }
        public PlanetSettings Planet { get; init; }
        public PlanetesimalSettings Planetesimal { get; init; }
        public ProtoplanetaryDiskSettings ProtoplanetaryDisk { get; init; }
        public PulsarSettings Pulsar { get; init; }
        public QuasarSettings Quasar { get; init; }
        public QuasarJetSettings QuasarJet { get; init; }
        public StarSettings Star { get; init; }
        public StarCloudSettings StarCloud { get; init; }
        public StarClusterSettings StarCluster { get; init; }
        public StarSystemSettings StarSystem { get; init; }
        public StellarNurserySettings StellarNursery { get; init; }
        public SuperclusterSettings Supercluster { get; init; }
        public SupernovaSettings Supernova { get; init; }
        public SupernovaRemnantSettings SupernovaRemnant { get; init; }
        public UniverseSettings Universe { get; init; }
        public VoidGalaxySettings VoidGalaxy { get; init; }





        public AstronomicalObjectSettings()
        {
            Theoretical = new TheoreticalAstronomicalObjectSettings();

            AccretionDisk = new AccretionDiskSettings();
            Asteroid = new AsteroidSettings();
            AsteroidBelt = new AsteroidBeltSettings();
            BaryonicMatterFilament = new BaryonicMatterFilamentSettings();
            BaryonicMatterFilamentStructure = new BaryonicMatterFilamentStructureSettings();
            BaryonicMatterNode = new BaryonicMatterNodeSettings();
            BaryonicMatterNodeStructure = new BaryonicMatterNodeStructureSettings();
            BaryonicMatterSheet = new BaryonicMatterSheetSettings();
            BaryonicMatterSheetStructure = new BaryonicMatterSheetStructureSettings();
            BaryonicMatterVoid = new BaryonicMatterVoidSettings();
            BaryonicMatterVoidStructure = new BaryonicMatterVoidStructureSettings();
            BlackHole = new BlackHoleSettings();
            Comet = new CometSettings();
            CosmicWeb = new CosmicWebSettings();
            Cubewano = new CubewanoSettings();
            DebrisDisk = new DebrisDiskSettings();
            Galaxy = new GalaxySettings();
            GalaxyCluster = new GalaxyClusterSettings();
            GalaxyGroup = new GalaxyGroupSettings();
            GammaRayBurst = new GammaRayBurstSettings();
            IntergalacticMedium = new IntergalacticMediumSettings();
            Jumbo = new JumboSettings();
            LargeQuasarGroup = new LargeQuasarGroupSettings();
            Moon = new MoonSettings();
            Nebula = new NebulaSettings();
            NeutronStar = new NeutronStarSettings();
            Nova = new NovaSettings();
            Planet = new PlanetSettings();
            Planetesimal = new PlanetesimalSettings();
            ProtoplanetaryDisk = new ProtoplanetaryDiskSettings();
            Pulsar = new PulsarSettings();
            Quasar = new QuasarSettings();
            QuasarJet = new QuasarJetSettings();
            Star = new StarSettings();
            StarCloud = new StarCloudSettings();
            StarCluster = new StarClusterSettings();
            StarSystem = new StarSystemSettings();
            StellarNursery = new StellarNurserySettings();
            Supercluster = new SuperclusterSettings();
            Supernova = new SupernovaSettings();
            SupernovaRemnant = new SupernovaRemnantSettings();
            Universe = new UniverseSettings();
            VoidGalaxy = new VoidGalaxySettings();
        }
    }
}