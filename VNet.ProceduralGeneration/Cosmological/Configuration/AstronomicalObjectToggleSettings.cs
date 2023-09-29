using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;


namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class AstronomicalObjectToggleSettings
    {
        [DisplayName("Accretion Disks")]
        [Tooltip("Flat, spiraled disk of matter that spirals inward onto a celestial body, often a black hole or star.")]
        public bool AccretionDisksEnabled { get; set; }

        [DisplayName("Asteroids")]
        [Tooltip("Rocky objects in space that are smaller than a planet but are not considered to be dwarf planets or satellites.")]
        public bool AsteroidsEnabled { get; set; }

        [DisplayName("Asteroid Belts")]
        [Tooltip("Region in space primarily between the orbits of Mars and Jupiter where most of the solar system's asteroids are located.")]
        public bool AsteroidBeltsEnabled { get; set; }

        [DisplayName("Filaments (Baryonic Matter)")]
        [Tooltip("Structures formed by baryonic matter, often forming the boundaries between cosmic voids.")]
        public bool BaryonicMatterFilamentsEnabled { get; set; }

        [DisplayName("Nodes (Baryonic Matter)")]
        [Tooltip("Dense regions where baryonic matter accumulates at the intersection of filaments.")]
        public bool BaryonicMatterNodesEnabled { get; set; }

        [DisplayName("Sheets (Baryonic Matter)")]
        [Tooltip("Flat structures formed by baryonic matter in the cosmic web.")]
        public bool BaryonicMatterSheetsEnabled { get; set; }

        [DisplayName("Voids (Baryonic Matter)")]
        [Tooltip("Expansive regions of space with relatively low baryonic matter density.")]
        public bool BaryonicMatterVoidsEnabled { get; set; }

        [DisplayName("Black Holes")]
        [Tooltip("Regions in space where gravity is so strong that nothing, not even light, can escape its grasp.")]
        public bool BlackHolesEnabled { get; set; }

        [DisplayName("Comets")]
        [Tooltip("Ice and dust-rich celestial bodies that orbit the Sun, often developing tails when close to it.")]
        public bool CometsEnabled { get; set; }

        [DisplayName("Cosmic Web")]
        [Tooltip("Vast cosmic structure comprising filaments, nodes, sheets, and voids, which contains most galaxies.")]
        public bool CosmicWebEnabled { get; set; }

        [DisplayName("Filaments (Dark Matter)")]
        [Tooltip("Structures in the universe formed primarily by dark matter and linking galaxy clusters.")]
        public bool DarkMatterFilamentsEnabled { get; set; }

        [DisplayName("Nodes (Dark Matter)")]
        [Tooltip("Regions of high dark matter density, often marking the intersection of cosmic filaments.")]
        public bool DarkMatterNodesEnabled { get; set; }

        [DisplayName("Sheets (Dark Matter)")]
        [Tooltip("Thin, expansive regions dense with dark matter.")]
        public bool DarkMatterSheetsEnabled { get; set; }

        [DisplayName("Voids (Dark Matter)")]
        [Tooltip("Regions with low concentrations of galaxies and dark matter.")]
        public bool DarkMatterVoidsEnabled { get; set; }

        [DisplayName("Galaxies")]
        [Tooltip("Massive systems consisting of stars, stellar remnants, interstellar gas and dust, and dark matter, all bound together by gravity.")]
        public bool GalaxiesEnabled { get; set; }

        [DisplayName("Galaxy Clusters")]
        [Tooltip("Collections of galaxies bound together by gravity, the largest known gravitationally bound structures.")]
        public bool GalaxyClustersEnabled { get; set; }

        [DisplayName("Galaxy Groups")]
        [Tooltip("Smaller collections of galaxies compared to clusters, bound together by gravity.")]
        public bool GalaxyGroupsEnabled { get; set; }

        [DisplayName("Gamma Ray Bursts (GRB)")]
        [Tooltip("Extremely energetic explosions, emitting very intense radiation, often associated with the death of a massive star or merger of neutron stars.")]
        public bool GammaRayBurstsEnabled { get; set; }

        [DisplayName("Icy Clouds")]
        [Tooltip("Clouds composed of ice particles and cold gases in interstellar space.")]
        public bool IcyCloudsEnabled { get; set; }

        [DisplayName("Icy Planets")]
        [Tooltip("Planets primarily composed of ices, and located beyond the solar system's frost line.")]
        public bool IcyPlanetsEnabled { get; set; }

        [DisplayName("Intergalactic Medium")]
        [Tooltip("Matter that exists in the space between galaxies within a galaxy cluster.")]
        public bool IntergalacticMediumEnabled { get; set; }

        [DisplayName("Large Quasar Groups (LQG)")]
        [Tooltip("Structures consisting of several quasars, considered the largest astronomical structures known.")]
        public bool LargeQuasarGroupsEnabled { get; set; }

        [DisplayName("Moons")]
        [Tooltip("Natural satellites orbiting planets or dwarf planets.")]
        public bool MoonsEnabled { get; set; }

        [DisplayName("Nebulae")]
        [Tooltip("Enormous clouds of dust and gas in space, often acting as stellar nurseries where stars are born.")]
        public bool NebulaeEnabled { get; set; }

        [DisplayName("Neutron Stars")]
        [Tooltip("Dense remnants of supernova explosions composed mostly of neutrons.")]
        public bool NeutronStarsEnabled { get; set; }

        [DisplayName("Novas")]
        [Tooltip("A star showing a sudden large increase in brightness and then slowly returning to its original state over weeks to years.")]
        public bool NovasEnabled { get; set; }

        [DisplayName("Planets")]
        [Tooltip("Celestial bodies orbiting a star or stellar remnant, massive enough to be spherical due to its gravity and has cleared its neighboring region of planetesimals.")]
        public bool PlanetsEnabled { get; set; }

        [DisplayName("Protoplanetary Disks")]
        [Tooltip("Rotating circumstellar disk of dense gas surrounding a young newly formed star, from which planets can form.")]
        public bool ProtoplanetaryDisksEnabled { get; set; }

        [DisplayName("Pulsars")]
        [Tooltip("Rotating neutron stars emitting beams of electromagnetic radiation out of their magnetic poles.")]
        public bool PulsarsEnabled { get; set; }

        [DisplayName("Quasars")]
        [Tooltip("Extremely bright and distant active galactic nucleus, powered by accretion of matter into supermassive black holes.")]
        public bool QuasarsEnabled { get; set; }

        [DisplayName("Quasar Jets")]
        [Tooltip("Energetic and narrow beams of ionized matter accelerated outward from the region near the black hole in quasars.")]
        public bool QuasarJetsEnabled { get; set; }

        [DisplayName("Stars")]
        [Tooltip("Massive, luminous celestial bodies consisting of plasma held together by their own gravity.")]
        public bool StarsEnabled { get; set; }

        [DisplayName("Star Clusters")]
        [Tooltip("Groups of stars that are gravitationally bound, often found in the spiral arms of galaxies.")]
        public bool StarClustersEnabled { get; set; }

        [DisplayName("Star Systems")]
        [Tooltip("A collection of celestial bodies, including a star and any planets, asteroids, comets, and other satellites.")]
        public bool StarSystemsEnabled { get; set; }

        [DisplayName("Stellar Formations and Objects")]
        [Tooltip("Various formations, structures, and objects related to stars, including their formation, lifecycle, and remnants.")]
        public bool StellarFormationsAndObjectsEnabled { get; set; }

        [DisplayName("Stellar Nurseries")]
        [Tooltip("Regions in space where new stars are born, typically dense areas in nebulae.")]
        public bool StellarNurseriesEnabled { get; set; }

        [DisplayName("Superclusters")]
        [Tooltip("Clusters of galaxies grouped together over scales of up to tens of megaparsecs.")]
        public bool SuperclustersEnabled { get; set; }

        [DisplayName("Supernovas")]
        [Tooltip("Explosive death of a star, resulting in a massive burst of energy and often leading to the formation of a neutron star or black hole.")]
        public bool SupernovasEnabled { get; set; }

        [DisplayName("Supernova Remnants")]
        [Tooltip("Structure resulting from the explosion of a star in a supernova, consisting of the ejected material and the interstellar material it sweeps up.")]
        public bool SupernovaRemnantsEnabled { get; set; }

        [DisplayName("Universe")]
        [Tooltip("All of space, time, matter, and energy in existence.")]
        public bool UniverseEnabled { get; set; }
    }
}