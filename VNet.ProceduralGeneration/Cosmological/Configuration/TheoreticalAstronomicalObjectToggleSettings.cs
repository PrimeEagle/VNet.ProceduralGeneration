using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class TheoreticalAstronomicalObjectToggleSettings : ISettings
{
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
}