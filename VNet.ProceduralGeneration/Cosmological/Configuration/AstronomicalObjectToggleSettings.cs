using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class AstronomicalObjectToggleSettings : ISettings
{
    [DisplayName("Accretion Disks")]
    [Tooltip("Flat, spiraled disk of matter that spirals inward onto a celestial body, often a black hole or star.")]
    public bool AccretionDisksEnabled { get; init; }

    [DisplayName("Asteroid Belts")]
    [Tooltip("Region in space primarily between the orbits of Mars and Jupiter where most of the solar system's asteroids are located.")]
    public bool AsteroidBeltsEnabled { get; init; }

    [DisplayName("Asteroids")]
    [Tooltip("Rocky objects in space that are smaller than a planet but are not considered to be dwarf planets or satellites.")]
    public bool AsteroidsEnabled { get; init; }

    [DisplayName("Filament Structure (Baryonic Matter)")]
    [Tooltip("Structures formed by baryonic matter, often forming the boundaries between cosmic voids.")]
    public bool BaryonicMatterFilamentsEnabled { get; init; }

    [DisplayName("Filaments (Baryonic Matter)")]
    [Tooltip("Structure consisting of all baryonic matter filaments.")]
    public bool BaryonicMatterFilamentStructureEnabled { get; init; }

    [DisplayName("Nodes (Baryonic Matter)")]
    [Tooltip("Dense regions where baryonic matter accumulates at the intersection of filaments.")]
    public bool BaryonicMatterNodesEnabled { get; init; }

    [DisplayName("Node Structure (Baryonic Matter)")]
    [Tooltip("Structure consisting of all baryonic matter nodes.")]
    public bool BaryonicMatterNodeStructureEnabled { get; init; }

    [DisplayName("Sheets (Baryonic Matter)")]
    [Tooltip("Flat structures formed by baryonic matter in the cosmic web.")]
    public bool BaryonicMatterSheetsEnabled { get; init; }

    [DisplayName("Sheet Structure (Baryonic Matter)")]
    [Tooltip("Structure consisting of all baryonic matter sheets.")]
    public bool BaryonicMatterSheetStructureEnabled { get; init; }

    [DisplayName("Voids (Baryonic Matter)")]
    [Tooltip("Expansive regions of space with relatively low baryonic matter density.")]
    public bool BaryonicMatterVoidsEnabled { get; init; }

    [DisplayName("Void Structure (Baryonic Matter)")]
    [Tooltip("Structure consisting of all baryonic matter voids.")]
    public bool BaryonicMatterVoidStructureEnabled { get; init; }

    [DisplayName("Black Holes")]
    [Tooltip("Regions in space where gravity is so strong that nothing, not even light, can escape its grasp.")]
    public bool BlackHolesEnabled { get; init; }

    [DisplayName("Comets")]
    [Tooltip("Ice and dust-rich celestial bodies that orbit the Sun, often developing tails when close to it.")]
    public bool CometsEnabled { get; init; }

    [DisplayName("Cosmic Web")]
    [Tooltip("Vast cosmic structure comprising filaments, nodes, sheets, and voids, which contains most galaxies.")]
    public bool CosmicWebEnabled { get; init; }

    [DisplayName("Cubewanos")]
    [Tooltip(".")]
    public bool CubewanosEnabled { get; init; }

    [DisplayName("Debris Disks")]
    [Tooltip(".")]
    public bool DebrisDisksEnabled { get; init; }

    [DisplayName("Galaxies")]
    [Tooltip("Massive systems consisting of stars, stellar remnants, interstellar gas and dust, and dark matter, all bound together by gravity.")]
    public bool GalaxiesEnabled { get; init; }

    [DisplayName("Galaxy Clusters")]
    [Tooltip("Collections of galaxies bound together by gravity, the largest known gravitationally bound structures.")]
    public bool GalaxyClustersEnabled { get; init; }

    [DisplayName("Galaxy Groups")]
    [Tooltip("Smaller collections of galaxies compared to clusters, bound together by gravity.")]
    public bool GalaxyGroupsEnabled { get; init; }

    [DisplayName("Gamma Ray Bursts (GRB)")]
    [Tooltip("Extremely energetic explosions, emitting very intense radiation, often associated with the death of a massive star or merger of neutron stars.")]
    public bool GammaRayBurstsEnabled { get; init; }

    [DisplayName("Intergalactic Medium")]
    [Tooltip("Matter that exists in the space between galaxies within a galaxy cluster.")]
    public bool IntergalacticMediumEnabled { get; init; }

    [DisplayName("JuMBOS")]
    [Tooltip(".")]
    public bool JumbosEnabled { get; init; }

    [DisplayName("Large Quasar Groups (LQG)")]
    [Tooltip("Structures consisting of several quasars, considered the largest astronomical structures known.")]
    public bool LargeQuasarGroupsEnabled { get; init; }

    [DisplayName("Moons")]
    [Tooltip("Natural satellites orbiting planets or dwarf planets.")]
    public bool MoonsEnabled { get; init; }

    [DisplayName("Nebulae")]
    [Tooltip("Enormous clouds of dust and gas in space, often acting as stellar nurseries where stars are born.")]
    public bool NebulaeEnabled { get; init; }

    [DisplayName("Neutron Stars")]
    [Tooltip("Dense remnants of supernova explosions composed mostly of neutrons.")]
    public bool NeutronStarsEnabled { get; init; }

    [DisplayName("Novas")]
    [Tooltip("A star showing a sudden large increase in brightness and then slowly returning to its original state over weeks to years.")]
    public bool NovasEnabled { get; init; }

    [DisplayName("Planetesimals")]
    [Tooltip(".")]
    public bool PlanetesimalsEnabled { get; init; }

    [DisplayName("Planets")]
    [Tooltip("Celestial bodies orbiting a star or stellar remnant, massive enough to be spherical due to its gravity and has cleared its neighboring region of planetesimals.")]
    public bool PlanetsEnabled { get; init; }

    [DisplayName("Protoplanetary Disks")]
    [Tooltip("Rotating circumstellar disk of dense gas surrounding a young newly formed star, from which planets can form.")]
    public bool ProtoplanetaryDisksEnabled { get; init; }

    [DisplayName("Pulsars")]
    [Tooltip("Rotating neutron stars emitting beams of electromagnetic radiation out of their magnetic poles.")]
    public bool PulsarsEnabled { get; init; }

    [DisplayName("Quasar Jets")]
    [Tooltip("Energetic and narrow beams of ionized matter accelerated outward from the region near the black hole in quasars.")]
    public bool QuasarJetsEnabled { get; init; }

    [DisplayName("Quasars")]
    [Tooltip("Extremely bright and distant active galactic nucleus, powered by accretion of matter into supermassive black holes.")]
    public bool QuasarsEnabled { get; init; }

    [DisplayName("Star Clouds")]
    [Tooltip(".")]
    public bool StarCloudsEnabled { get; init; }

    [DisplayName("Star Clusters")]
    [Tooltip("Groups of stars that are gravitationally bound, often found in the spiral arms of galaxies.")]
    public bool StarClustersEnabled { get; init; }

    [DisplayName("Stars")]
    [Tooltip("Massive, luminous celestial bodies consisting of plasma held together by their own gravity.")]
    public bool StarsEnabled { get; init; }

    [DisplayName("Star Systems")]
    [Tooltip("A collection of celestial bodies, including a star and any planets, asteroids, comets, and other satellites.")]
    public bool StarSystemsEnabled { get; init; }

    [DisplayName("Stellar Formations and Objects")]
    [Tooltip("Various formations, structures, and objects related to stars, including their formation, lifecycle, and remnants.")]
    public bool StellarFormationsAndObjectsEnabled { get; init; }

    [DisplayName("Stellar Nurseries")]
    [Tooltip("Regions in space where new stars are born, typically dense areas in nebulae.")]
    public bool StellarNurseriesEnabled { get; init; }

    [DisplayName("Superclusters")]
    [Tooltip("Clusters of galaxies grouped together over scales of up to tens of megaparsecs.")]
    public bool SuperclustersEnabled { get; init; }

    [DisplayName("Supernova Remnants")]
    [Tooltip("Structure resulting from the explosion of a star in a supernova, consisting of the ejected material and the interstellar material it sweeps up.")]
    public bool SupernovaRemnantsEnabled { get; init; }

    [DisplayName("Supernovas")]
    [Tooltip("Explosive death of a star, resulting in a massive burst of energy and often leading to the formation of a neutron star or black hole.")]
    public bool SupernovasEnabled { get; init; }

    [DisplayName("Universe")]
    [Tooltip("All of space, time, matter, and energy in existence.")]
    public bool UniverseEnabled { get; init; }

    [DisplayName("Void Galaxies")]
    [Tooltip(".")]
    public bool VoidGalaxiesEnabled { get; init; }
}