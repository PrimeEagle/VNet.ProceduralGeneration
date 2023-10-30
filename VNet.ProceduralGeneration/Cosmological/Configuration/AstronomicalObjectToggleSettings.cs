using System.ComponentModel;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class AstronomicalObjectToggleSettings
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

    [DisplayName("Exocometary Cloud")]
    [Tooltip(".")]
    public bool ExocometaryCloudEnabled { get; init; }

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

    [DisplayName("Branes")]
    [Tooltip("Multidimensional structures postulated in string theory and other theoretical physics models.")]
    public bool BranesEnabled { get; init; }

    [DisplayName("Cosmic Bubbles")]
    [Tooltip("Regions of space with different properties, possibly due to phase transitions in the early universe.")]
    public bool CosmicBubblesEnabled { get; init; }

    [DisplayName("Cosmic Dust Lanes")]
    [Tooltip("Regions in space filled with dense interstellar dust, obscuring light and altering the path of electromagnetic waves.")]
    public bool CosmicDustLanesEnabled { get; init; }

    [DisplayName("Cosmic Strings")]
    [Tooltip("One-dimensional topological defects which may have formed during symmetry breaking in the early universe.")]
    public bool CosmicStringsEnabled { get; init; }

    [DisplayName("Cosmic Topological Defects")]
    [Tooltip("Discontinuities in the fabric of space-time theorized to form during certain phase transitions.")]
    public bool CosmicTopologicalDefectsEnabled { get; init; }

    [DisplayName("Cosmic Tornados")]
    [Tooltip("Hypothetical vortices of energy speculated to exist in space; not widely recognized in astrophysics.")]
    public bool CosmicTornadosEnabled { get; init; }

    [DisplayName("Cusp Catastrophes")]
    [Tooltip("Mathematical concepts in catastrophe theory which might have applications in cosmological scenarios.")]
    public bool CuspCatastrophesEnabled { get; init; }

    [DisplayName("Dark Matter and Dark Energy")]
    [Tooltip("Controls whether the effects of dark matter are taken into account for various calculations, such as gravity.")]
    public bool DarkMatterAndDarkEnergyEnabled { get; init; }

    [FalseIfFalse(nameof(DarkMatterAndDarkEnergyEnabled))]
    [DisplayName("Filaments (Dark Matter)")]
    [Tooltip("Structures in the universe formed primarily by dark matter and linking galaxy clusters.")]
    public bool DarkMatterFilamentsEnabled { get; init; }

    [FalseIfFalse(nameof(DarkMatterAndDarkEnergyEnabled))]
    [DisplayName("Filament Structure (Dark Matter)")]
    [Tooltip("Structure consisting of all dark matter filaments.")]
    public bool DarkMatterFilamentStructureEnabled { get; init; }

    [FalseIfFalse(nameof(DarkMatterAndDarkEnergyEnabled))]
    [DisplayName("Nodes (Dark Matter)")]
    [Tooltip("Regions of high dark matter density, often marking the intersection of cosmic filaments.")]
    public bool DarkMatterNodesEnabled { get; init; }

    [FalseIfFalse(nameof(DarkMatterAndDarkEnergyEnabled))]
    [DisplayName("Node Structure (Dark Matter)")]
    [Tooltip("Structure consisting of all dark matter nodes.")]
    public bool DarkMatterNodeStructureEnabled { get; init; }

    [FalseIfFalse(nameof(DarkMatterAndDarkEnergyEnabled))]
    [DisplayName("Sheets (Dark Matter)")]
    [Tooltip("Thin, expansive regions dense with dark matter.")]
    public bool DarkMatterSheetsEnabled { get; init; }

    [FalseIfFalse(nameof(DarkMatterAndDarkEnergyEnabled))]
    [DisplayName("Sheet Structure (Dark Matter)")]
    [Tooltip("Structure consisting of all dark matter sheets.")]
    public bool DarkMatterSheetStructureEnabled { get; init; }

    [FalseIfFalse(nameof(DarkMatterAndDarkEnergyEnabled))]
    [DisplayName("Voids (Dark Matter)")]
    [Tooltip("Regions with low concentrations of galaxies and dark matter.")]
    public bool DarkMatterVoidsEnabled { get; init; }

    [FalseIfFalse(nameof(DarkMatterAndDarkEnergyEnabled))]
    [DisplayName("Voids Structure (Dark Matter)")]
    [Tooltip("Structure consisting of all dark matter voids.")]
    public bool DarkMatterVoidStructureEnabled { get; init; }

    [DisplayName("Dark Stars")]
    [Tooltip("Early stars theorized to be powered by dark matter annihilation rather than nuclear fusion.")]
    public bool DarkStarsEnabled { get; init; }

    [DisplayName("Domain Walls")]
    [Tooltip("Two-dimensional topological defects that can form when a discrete symmetry is spontaneously broken.")]
    public bool DomainWallsEnabled { get; init; }

    [DisplayName("Dyson Spheres")]
    [Tooltip("Megastructures that encircle a star, capturing its energy output for advanced civilizations.")]
    public bool DysonSpheresEnabled { get; init; }

    [DisplayName("Fermi Bubbles")]
    [Tooltip("Giant structures emanating from the center of the Milky Way, possibly resulting from past energetic processes around the galactic center.")]
    public bool FermiBubblesEnabled { get; init; }

    [DisplayName("Fuzzballs")]
    [Tooltip("Alternative descriptions for black holes in string theory which avoid the singularity.")]
    public bool FuzzballsEnabled { get; init; }

    [DisplayName("Kugelblitzes")]
    [Tooltip("Hypothetical black holes formed from the radiation and energy instead of matter.")]
    public bool KugelblitzesEnabled { get; init; }

    [DisplayName("Magnetars")]
    [Tooltip("A type of neutron star with extremely powerful magnetic fields.")]
    public bool MagnetarsEnabled { get; init; }

    [DisplayName("Monopoles")]
    [Tooltip("Hypothetical particles that carry a single magnetic charge, either north or south.")]
    public bool MonopolesEnabled { get; init; }

    [DisplayName("Naked Singularities")]
    [Tooltip("Points in spacetime where gravitational forces cause matter to have an infinite density; they exist outside of a black hole.")]
    public bool NakedSingularitiesEnabled { get; init; }

    [DisplayName("Planck Stars")]
    [Tooltip("Theoretical stars formed from quantum gravitational effects at the core of a black hole.")]
    public bool PlanckStarsEnabled { get; init; }

    [DisplayName("Preon Stars")]
    [Tooltip("Compact stars made of preons, particles that are postulated to be subcomponents of quarks and leptons.")]
    public bool PreonStarsEnabled { get; init; }

    [DisplayName("Primordial Black Holes")]
    [Tooltip("Small black holes theorized to have formed shortly after the Big Bang.")]
    public bool PrimordialBlackHolesEnabled { get; init; }

    [DisplayName("Quantum Black Holes")]
    [Tooltip("Small black holes where quantum effects play a significant role.")]
    public bool QuantumBlackHolesEnabled { get; init; }

    [DisplayName("Quark Stars")]
    [Tooltip("Hypothetical type of neutron star composed of quark matter.")]
    public bool QuarkStarsEnabled { get; init; }

    [DisplayName("Wormholes (Spatial)")]
    [Tooltip("Tunnels in spacetime which potentially connect distant regions of the universe.")]
    public bool SpatialWormholesEnabled { get; init; }

    [DisplayName("Tachyonic Fields")]
    [Tooltip("Fields associated with particles that always move faster than light.")]
    public bool TachyonicFieldsEnabled { get; init; }

    [DisplayName("Wormholes (Temporal)")]
    [Tooltip("Tunnels in spacetime connecting different points in time.")]
    public bool TemporalWormholesEnabled { get; init; }

    [DisplayName("Wormholes (Transdimensional)")]
    [Tooltip("Tunnels between different universes or dimensions.")]
    public bool TransdimensionalWormholesEnabled { get; init; }

    [DisplayName("White Holes")]
    [Tooltip("Region of spacetime which cannot be entered from the outside, but from which matter and light may escape.")]
    public bool WhiteHolesEnabled { get; init; }


    public AstronomicalObjectToggleSettings()
    {
    }
}