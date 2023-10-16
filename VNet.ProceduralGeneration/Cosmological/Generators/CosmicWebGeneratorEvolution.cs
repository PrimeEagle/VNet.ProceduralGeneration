using VNet.Mathematics.LinearAlgebra.Matrix;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.Scientific.NumericalVolumes;
using VNet.System.Events;

// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable PossibleLossOfFraction
// ReSharper disable MemberCanBeMadeStatic.Global
#pragma warning disable CA1822
#pragma warning disable IDE0060
#pragma warning disable CS0649

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public partial class CosmicWebGeneratorEvo : GroupGeneratorBase<CosmicWeb, CosmicWebContext>
{
    private readonly double[,,] _heliumVolume;
    private readonly double[,,] _hydrogenVolume;
    private readonly double[,,] _massArray;
    private readonly double[,,] _metalVolume;
    private readonly double[,,] _tempMassArray;
    private readonly double[,,] _velocityXArray;
    private readonly double[,,] _velocityYArray;
    private readonly double[,,] _velocityZArray;
    private double[,,] _baryonicVolume;
    private double _darkEnergyEffect;
    private double[,,] _darkMatterVolume;
    private double[,,] _temperatureVolume;
    private double _totalEnergy;


    private void GenerateCosmicWebByEvolution(CosmicWebContext context, CosmicWeb self)
    {
        _darkEnergyEffect = Math.Pow(1 + Context.DarkEnergyPercentage / 100.0, 0.5) - 1;

        InitializeVolumes();

        double currentTime = 0;

        while (currentTime < Context.Age)
        {
            ApplyGravity(context, self, currentTime);
            UpdateVelocitiesBasedOnForces(context, self, currentTime);
            ApplyRadiation(context, self, currentTime);
            ApplyBaryonicFeedback(context, self, currentTime);
            ApplyStarFormationAndChemicalEvolution(context, self, currentTime);
            ApplyHeatingAndCooling(context, self, currentTime);
            ApplyShockHeating(context, self, currentTime);
            ApplyMerging();
            ApplyGalacticFeedback(context, self, currentTime);
            ApplyExpansion(context, self, currentTime);
            AdvectMass(context, self, currentTime);
            HandleBoundaries();

            currentTime += AdvancedSettings.Objects.CosmicWeb.EvolutionTimeStep;
        }

        var smoothedVolume = VolumeProcessing.ApplyGaussianSmoothing(_baryonicVolume, AdvancedSettings.Objects.CosmicWeb.SigmaForStructureIdentification);
        IdentifyStructures(smoothedVolume);

        var labels = LabelConnectedComponents(smoothedVolume);
        var extractedRegions = ExtractLabeledRegions(labels);
    }

    private void InitializeVolumes()
    {
        _baryonicVolume = new double[Context.MapX, Context.MapY, Context.MapZ];
        _darkMatterVolume = new double[Context.MapX, Context.MapY, Context.MapZ];
        _temperatureVolume = new double[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            var totalNoise = AdvancedSettings.Objects.CosmicWeb.EvolutionNoiseAlgorithm.GenerateSingleSample();

            _baryonicVolume[i, j, k] = totalNoise * Context.BaryonicMatterPercentage / 100.0;
            _darkMatterVolume[i, j, k] = totalNoise * Context.DarkMatterPercentage / 100.0;

            var temperatureNoise = AdvancedSettings.Objects.CosmicWeb.EvolutionTemperatureNoiseAlgorithm.GenerateSingleSample(); // Assumed to be in range [-1, 1]
            var temperatureFluctuation = temperatureNoise * AdvancedSettings.Objects.CosmicWeb.EvolutionTemperatureFluctuationRange;
            _temperatureVolume[i, j, k] = Context.CosmicMicrowaveBackground + temperatureFluctuation;

            var totalBaryonicDensity = _baryonicVolume[i, j, k];
            _hydrogenVolume[i, j, k] = AdvancedSettings.Objects.CosmicWeb.EvolutionInitialHydrogenPercentage / 100 * totalBaryonicDensity;
            _heliumVolume[i, j, k] = AdvancedSettings.Objects.CosmicWeb.EvolutionInitialHeliumPercentage / 100 * totalBaryonicDensity;
            _metalVolume[i, j, k] = AdvancedSettings.Objects.CosmicWeb.EvolutionInitialMetalPercentage / 100 * totalBaryonicDensity;
            _massArray[i, j, k] = _baryonicVolume[i, j, k] + _darkMatterVolume[i, j, k];
            _totalEnergy += _temperatureVolume[i, j, k];
        });
    }

    private void UpdateVelocitiesBasedOnForces(CosmicWebContext context, CosmicWeb self, double timeStep)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            double accelerationX = 0;
            double accelerationY = 0;
            double accelerationZ = 0;

            VolumeFunctions.RunNeighborFunction(-1, 1, (dx, dy, dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz) || (dx == 0 && dy == 0 && dz == 0)) return;
                var aGravity = AdvancedSettings.PhysicalConstants.G * _massArray[i + dx, j + dy, k + dz];
                accelerationX += dx == 0 ? 0 : dx / Math.Abs(dx) * aGravity;
                accelerationY += dy == 0 ? 0 : dy / Math.Abs(dy) * aGravity;
                accelerationZ += dz == 0 ? 0 : dz / Math.Abs(dz) * aGravity;
            });

            _velocityXArray[i, j, k] += accelerationX * timeStep;
            _velocityYArray[i, j, k] += accelerationY * timeStep;
            _velocityZArray[i, j, k] += accelerationZ * timeStep;
        });
    }

    private void AdvectMass(CosmicWebContext context, CosmicWeb self, double timeStep)
    {
        Array.Copy(_massArray, _tempMassArray, _massArray.Length);

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            var dx = (int)(_velocityXArray[i, j, k] * timeStep);
            var dy = (int)(_velocityYArray[i, j, k] * timeStep);
            var dz = (int)(_velocityZArray[i, j, k] * timeStep);

            if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
            _tempMassArray[i + dx, j + dy, k + dz] += _massArray[i, j, k];
            _tempMassArray[i, j, k] -= _massArray[i, j, k];
        });

        Array.Copy(_tempMassArray, _massArray, _massArray.Length);
    }

    private bool IsWithinBounds(int x, int y, int z)
    {
        return x >= 0 && x < Context.MapX &&
               y >= 0 && y < Context.MapY &&
               z >= 0 && z < Context.MapZ;
    }

    private void HandleBoundaries()
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            if (i != 0 && i != Context.MapX - 1 &&
                j != 0 && j != Context.MapY - 1 &&
                k != 0 && k != Context.MapZ - 1) return;

            _totalEnergy -= _massArray[i, j, k] * _temperatureVolume[i, j, k];
            _massArray[i, j, k] = 0;
            _temperatureVolume[i, j, k] = 0;
        });
    }

    private void ApplyGalacticFeedback(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            if (_baryonicVolume[i, j, k] <= AdvancedSettings.Objects.CosmicWeb.EvolutionGalacticFeedbackThreshold) return;

            var energyReductionFromDensity = AdvancedSettings.Objects.CosmicWeb.EvolutionGalacticFeedbackEnergy * timeInYears;
            var energyIncreaseFromTemperature = AdvancedSettings.Objects.CosmicWeb.EvolutionGalacticFeedbackEnergy * timeInYears;

            _totalEnergy -= energyReductionFromDensity;
            _totalEnergy += energyIncreaseFromTemperature;

            _baryonicVolume[i, j, k] -= energyReductionFromDensity;
            _temperatureVolume[i, j, k] += energyIncreaseFromTemperature;

            VolumeFunctions.RunNeighborFunction(-1, 1, (dx, dy, dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;

                var localEnergyReduction = AdvancedSettings.Objects.CosmicWeb.EvolutionGalacticFeedbackEnergy * timeInYears / 3;
                var localEnergyIncrease = AdvancedSettings.Objects.CosmicWeb.EvolutionGalacticFeedbackEnergy * timeInYears / 3;

                _totalEnergy -= localEnergyReduction;
                _totalEnergy += localEnergyIncrease;

                _baryonicVolume[i + dx, j + dy, k + dz] -= localEnergyReduction;
                _temperatureVolume[i + dx, j + dy, k + dz] += localEnergyIncrease;
            });
        });
    }

    private void ApplyStarFormationAndChemicalEvolution(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            if (_baryonicVolume[i, j, k] <= AdvancedSettings.Objects.CosmicWeb.EvolutionStellarFormationMinimumDensityThreshold || _temperatureVolume[i, j, k] >= AdvancedSettings.Objects.CosmicWeb.EvolutionStarFormationMaximumTemperatureThreshold) return;
            var starsFormed = AdvancedSettings.Objects.CosmicWeb.EvolutionPercentGasConvertedToStars / 100 * _baryonicVolume[i, j, k] * timeInYears;

            _totalEnergy -= starsFormed;
            _baryonicVolume[i, j, k] -= starsFormed;

            var metalFormed = AdvancedSettings.Objects.CosmicWeb.EvolutionPercentOfStarMassConvertedToMetals / 100 * starsFormed;
            _metalVolume[i, j, k] += metalFormed;
            _totalEnergy += metalFormed;

            var hydrogenFormed = AdvancedSettings.Objects.CosmicWeb.EvolutionPercentOfStarMassRetainedAsHydrogen / 100 * starsFormed;
            _hydrogenVolume[i, j, k] -= hydrogenFormed;
            _totalEnergy -= hydrogenFormed;
        });
    }

    private void ApplyMerging()
    {
        var changeInMass = new double[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            if (_baryonicVolume[i, j, k] <= AdvancedSettings.Objects.CosmicWeb.EvolutionMergingThreshold) return;

            var excessMass = _baryonicVolume[i, j, k] - AdvancedSettings.Objects.CosmicWeb.EvolutionMergingThreshold;
            changeInMass[i, j, k] -= excessMass;

            var countNeighbors = 0;

            VolumeFunctions.RunNeighborFunction(-AdvancedSettings.Objects.CosmicWeb.EvolutionMergingRadius, AdvancedSettings.Objects.CosmicWeb.EvolutionMergingRadius, (dx, dy, dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
                countNeighbors++;
            });

            VolumeFunctions.RunNeighborFunction(-AdvancedSettings.Objects.CosmicWeb.EvolutionMergingRadius, AdvancedSettings.Objects.CosmicWeb.EvolutionMergingRadius, (dx, dy, dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
                changeInMass[i + dx, j + dy, k + dz] += excessMass / countNeighbors;
            });
        });

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) => { _baryonicVolume[i, j, k] = Math.Max(0, _baryonicVolume[i, j, k] + changeInMass[i, j, k]); });
    }

    private void ApplyShockHeating(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            var densityGradient = CalculateDensityGradient(i, j, k);
            if (densityGradient > AdvancedSettings.Objects.CosmicWeb.EvolutionShockHeatingMinimumDensityThreshold) _temperatureVolume[i, j, k] += AdvancedSettings.Objects.CosmicWeb.EvolutionTemperatureIncreaseDueToShockHeating;
        });
    }

    private double CalculateDensityGradient(int i, int j, int k)
    {
        double gradient = 0;

        VolumeFunctions.RunNeighborFunction(-1, 1, (dx, dy, dz) =>
        {
            if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
            gradient += Math.Abs(_baryonicVolume[i + dx, j + dy, k + dz] - _baryonicVolume[i, j, k]);
        });

        // Normalize by number of neighbors (for a 3x3x3 cube it's 27 cells minus the center cell)
        gradient /= 26.0;
        return gradient;
    }

    private void ApplyGravity(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        var updatedBaryonicVolume = new double[Context.MapX, Context.MapY, Context.MapZ];
        var updatedDarkMatterVolume = new double[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            double gravitationalEffectBaryonic = 0;
            double gravitationalEffectDarkMatter = 0;

            VolumeFunctions.RunNeighborFunction(-AdvancedSettings.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfGravity, AdvancedSettings.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfGravity, (dx, dy, dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
                double distanceSquared = dx * dx + dy * dy + dz * dz;
                if (distanceSquared == 0) return;

                gravitationalEffectBaryonic += AdvancedSettings.PhysicalConstants.G * (_baryonicVolume[i + dx, j + dy, k + dz] + _darkMatterVolume[i + dx, j + dy, k + dz]) / distanceSquared;
                gravitationalEffectDarkMatter += AdvancedSettings.PhysicalConstants.G * (_baryonicVolume[i + dx, j + dy, k + dz] + _darkMatterVolume[i + dx, j + dy, k + dz]) / distanceSquared;
            });

            updatedBaryonicVolume[i, j, k] = _baryonicVolume[i, j, k] + gravitationalEffectBaryonic * timeInYears;
            updatedDarkMatterVolume[i, j, k] = _darkMatterVolume[i, j, k] + gravitationalEffectDarkMatter * timeInYears;
        });

        Array.Copy(updatedBaryonicVolume, _baryonicVolume, updatedBaryonicVolume.Length);
        Array.Copy(updatedDarkMatterVolume, _darkMatterVolume, updatedDarkMatterVolume.Length);
    }

    private void ApplyRadiation(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        var currentRadiationStrength = AdvancedSettings.Objects.CosmicWeb.EvolutionInitialRadiationStrength * Math.Exp(-AdvancedSettings.Objects.CosmicWeb.EvolutionRadiationDecayRate * timeInYears);

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            double radiationEffect = 0;

            VolumeFunctions.RunNeighborFunction(-AdvancedSettings.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfRadiation, AdvancedSettings.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfRadiation, (dx, dy, dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
                double distanceSquared = dx * dx + dy * dy + dz * dz;
                if (distanceSquared == 0) return;

                radiationEffect -= currentRadiationStrength * _baryonicVolume[i + dx, j + dy, k + dz] / distanceSquared;
            });

            _baryonicVolume[i, j, k] += radiationEffect * timeInYears;
        });
    }

    private void ApplyExpansion(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        var currentDarkEnergyDensity = self.Universe.OmegaDarkEnergy * self.Universe.CriticalDensity;


        _baryonicVolume = VolumeProcessing.InterpolateVolume(_baryonicVolume, self.Universe.ExpansionRate, AdvancedSettings.Objects.CosmicWeb.EvolutionInterpolationAlgorithm);
        _darkMatterVolume = VolumeProcessing.InterpolateVolume(_darkMatterVolume, self.Universe.ExpansionRate, AdvancedSettings.Objects.CosmicWeb.EvolutionInterpolationAlgorithm);
    }


    private void ApplyBaryonicFeedback(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        var feedbackEffects = new double[Context.MapX, Context.MapY, Context.MapZ];
        var energyInjected = new double[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            if (!(_baryonicVolume[i, j, k] > AdvancedSettings.Objects.CosmicWeb.EvolutionBaryonicFeedbackThreshold)) return;
            var feedback = AdvancedSettings.Objects.CosmicWeb.EvolutionBaryonicFeedbackStrength * timeInYears;
            _baryonicVolume[i, j, k] -= feedback;
            feedbackEffects[i, j, k] = feedback * AdvancedSettings.Objects.CosmicWeb.EvolutionBaryonicFeedbackSpread;

            var energyChange = AdvancedSettings.Objects.CosmicWeb.EvolutionBaseHeatingRate * timeInYears;
            _temperatureVolume[i, j, k] += energyChange;
            energyInjected[i, j, k] = energyChange;
        });

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            if (!(feedbackEffects[i, j, k] > 0)) return;

            VolumeFunctions.RunNeighborFunction(-1, 1, (dx, dy, dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz) || (dx == 0 && dy == 0 && dz == 0)) return;
                _baryonicVolume[i + dx, j + dy, k + dz] += feedbackEffects[i, j, k] / 26.0;
                _temperatureVolume[i + dx, j + dy, k + dz] += energyInjected[i, j, k] / 26.0;
            });
        });
    }

    private void ApplyHeatingAndCooling(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            var localDensity = _baryonicVolume[i, j, k];
            var effectiveCoolingRate = AdvancedSettings.Objects.CosmicWeb.EvolutionBaseCoolingRate * (1 + AdvancedSettings.Objects.CosmicWeb.EvolutionCoolingRateDensityFactor * localDensity);
            var effectiveHeatingRate = AdvancedSettings.Objects.CosmicWeb.EvolutionBaseHeatingRate * (1 - AdvancedSettings.Objects.CosmicWeb.EvolutionHeatingRateDensityFactor * localDensity);
            effectiveCoolingRate += AdvancedSettings.Objects.CosmicWeb.EvolutionCollisionalCoolingFactor * localDensity * localDensity;
            effectiveHeatingRate += AdvancedSettings.Objects.CosmicWeb.EvolutionCollisionalHeatingFactor * localDensity * localDensity;

            var energyChangeDueToCooling = effectiveCoolingRate * timeInYears * _temperatureVolume[i, j, k];
            var energyChangeDueToHeating = effectiveHeatingRate * timeInYears;

            _temperatureVolume[i, j, k] -= energyChangeDueToCooling;
            _temperatureVolume[i, j, k] += energyChangeDueToHeating;

            _totalEnergy -= energyChangeDueToCooling;
            _totalEnergy += energyChangeDueToHeating;
        });
    }

    private void IdentifyStructures(double[,,] smoothedVolume)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            var density = smoothedVolume[i, j, k];

            if (density < AdvancedSettings.Objects.CosmicWeb.EvolutionDensityThresholdForVoidIdentification)
                // Void
                return;

            if (density < AdvancedSettings.Objects.CosmicWeb.EvolutionDensityThresholdForStructureIdentification)
                // Uninteresting region, can skip or label accordingly
                return;

            var eigenValues = Hessian.EigenValues(i, j, k, smoothedVolume);

            switch (eigenValues[0])
            {
                case > 0 when eigenValues[1] > 0 && eigenValues[2] > 0:
                    // Node
                    break;
                case > 0 when eigenValues[1] > 0 && eigenValues[2] < 0:
                    // Filament
                    break;
                case > 0 when eigenValues[1] < 0 && eigenValues[2] < 0:
                    // Sheet
                    break;
            }
        });
    }

    private int[,,] LabelConnectedComponents(double[,,] structureVolume)
    {
        var labels = new int[Context.MapX, Context.MapY, Context.MapZ];
        var currentLabel = 1;

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            if (!(structureVolume[i, j, k] > AdvancedSettings.Objects.CosmicWeb.EvolutionDensityThresholdForStructureIdentification) || labels[i, j, k] != 0) return;
            VolumeProcessing.FloodFill(structureVolume, labels, i, j, k, currentLabel, AdvancedSettings.Objects.CosmicWeb.EvolutionDensityThresholdForStructureIdentification);
            currentLabel++;
        });

        return labels;
    }

    private Dictionary<int, List<(int x, int y, int z)>> ExtractLabeledRegions(int[,,] labels)
    {
        var regions = new Dictionary<int, List<(int x, int y, int z)>>();

        VolumeFunctions.RunVolumeFunction(labels.GetLength(0), labels.GetLength(1), labels.GetLength(2), (i, j, k) =>
        {
            var label = labels[i, j, k];
            if (label <= 0) return;
            if (!regions.ContainsKey(label)) regions[label] = new List<(int x, int y, int z)>();

            regions[label].Add((i, j, k));
        });

        return regions;
    }

    protected override Task<CosmicWeb> GenerateSelf(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    public CosmicWebGeneratorEvo(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }
}