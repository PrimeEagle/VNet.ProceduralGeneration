using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;


namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class TheoreticalAstronomicalObjectToggleSettings : ISettings
{
        [DisplayName("Branes")]
        [Tooltip("Multidimensional structures postulated in string theory and other theoretical physics models.")]
        public bool BranesEnabled { get; set; }

        [DisplayName("Cosmic Bubbles")]
        [Tooltip("Regions of space with different properties, possibly due to phase transitions in the early universe.")]
        public bool CosmicBubblesEnabled { get; set; }

        [DisplayName("Cosmic Dust Lanes")]
        [Tooltip("Regions in space filled with dense interstellar dust, obscuring light and altering the path of electromagnetic waves.")]
        public bool CosmicDustLanesEnabled { get; set; }

        [DisplayName("Cosmic Strings")]
        [Tooltip("One-dimensional topological defects which may have formed during symmetry breaking in the early universe.")]
        public bool CosmicStringsEnabled { get; set; }

        [DisplayName("Cosmic Topological Defects")]
        [Tooltip("Discontinuities in the fabric of space-time theorized to form during certain phase transitions.")]
        public bool CosmicTopologicalDefectsEnabled { get; set; }

        [DisplayName("Cosmic Tornados")]
        [Tooltip("Hypothetical vortices of energy speculated to exist in space; not widely recognized in astrophysics.")]
        public bool CosmicTornadosEnabled { get; set; }

        [DisplayName("Cusp Catastrophes")]
        [Tooltip("Mathematical concepts in catastrophe theory which might have applications in cosmological scenarios.")]
        public bool CuspCatastrophesEnabled { get; set; }

        [DisplayName("Dark Stars")]
        [Tooltip("Early stars theorized to be powered by dark matter annihilation rather than nuclear fusion.")]
        public bool DarkStarsEnabled { get; set; }

        [DisplayName("Domain Walls")]
        [Tooltip("Two-dimensional topological defects that can form when a discrete symmetry is spontaneously broken.")]
        public bool DomainWallsEnabled { get; set; }

        [DisplayName("Dyson Spheres")]
        [Tooltip("Megastructures that encircle a star, capturing its energy output for advanced civilizations.")]
        public bool DysonSpheresEnabled { get; set; }

        [DisplayName("Fermi Bubbles")]
        [Tooltip("Giant structures emanating from the center of the Milky Way, possibly resulting from past energetic processes around the galactic center.")]
        public bool FermiBubblesEnabled { get; set; }

        [DisplayName("Fuzzballs")]
        [Tooltip("Alternative descriptions for black holes in string theory which avoid the singularity.")]
        public bool FuzzballsEnabled { get; set; }

        [DisplayName("Kugelblitzes")]
        [Tooltip("Hypothetical black holes formed from the radiation and energy instead of matter.")]
        public bool KugelblitzesEnabled { get; set; }

        [DisplayName("Magnetars")]
        [Tooltip("A type of neutron star with extremely powerful magnetic fields.")]
        public bool MagnetarsEnabled { get; set; }

        [DisplayName("Monopoles")]
        [Tooltip("Hypothetical particles that carry a single magnetic charge, either north or south.")]
        public bool MonopolesEnabled { get; set; }

        [DisplayName("Naked Singularities")]
        [Tooltip("Points in spacetime where gravitational forces cause matter to have an infinite density; they exist outside of a black hole.")]
        public bool NakedSingularitiesEnabled { get; set; }

        [DisplayName("Planck Stars")]
        [Tooltip("Theoretical stars formed from quantum gravitational effects at the core of a black hole.")]
        public bool PlanckStarsEnabled { get; set; }

        [DisplayName("Preon Stars")]
        [Tooltip("Compact stars made of preons, particles that are postulated to be subcomponents of quarks and leptons.")]
        public bool PreonStarsEnabled { get; set; }

        [DisplayName("Primordial Black Holes")]
        [Tooltip("Small black holes theorized to have formed shortly after the Big Bang.")]
        public bool PrimordialBlackHolesEnabled { get; set; }

        [DisplayName("Quantum Black Holes")]
        [Tooltip("Small black holes where quantum effects play a significant role.")]
        public bool QuantumBlackHolesEnabled { get; set; }

        [DisplayName("Quark Stars")]
        [Tooltip("Hypothetical type of neutron star composed of quark matter.")]
        public bool QuarkStarsEnabled { get; set; }

        [DisplayName("Wormholes (Spatial)")]
        [Tooltip("Tunnels in spacetime which potentially connect distant regions of the universe.")]
        public bool SpatialWormholesEnabled { get; set; }

        [DisplayName("Tachyonic Fields")]
        [Tooltip("Fields associated with particles that always move faster than light.")]
        public bool TachyonicFieldsEnabled { get; set; }

        [DisplayName("Wormholes (Temporal)")]
        [Tooltip("Tunnels in spacetime connecting different points in time.")]
        public bool TemporalWormholesEnabled { get; set; }

        [DisplayName("Wormholes (Transdimensional)")]
        [Tooltip("Tunnels between different universes or dimensions.")]
        public bool TransdimensionalWormholesEnabled { get; set; }

        [DisplayName("White Holes")]
        [Tooltip("Region of spacetime which cannot be entered from the outside, but from which matter and light may escape.")]
        public bool WhiteHolesEnabled { get; set; }
    }
}