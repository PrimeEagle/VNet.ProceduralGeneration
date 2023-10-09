using VNet.Mathematics.LinearAlgebra.Matrix;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;
using VNet.Scientific.NumericalVolumes;

// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable PossibleLossOfFraction
// ReSharper disable MemberCanBeMadeStatic.Global
#pragma warning disable CA1822
#pragma warning disable IDE0060
#pragma warning disable CS0649


namespace VNet.ProceduralGeneration.Cosmological.Generators;

public partial class CosmicWebGenerator : ContainerGeneratorBase<CosmicWeb, CosmicWebContext>
{
    private double[,,] _baryonicVolume;
    private double[,,] _darkMatterVolume;
    private readonly double[,,] _hydrogenVolume;
    private readonly double[,,] _heliumVolume;
    private readonly double[,,] _metalVolume;
    private readonly double[,,] _massArray;
    private readonly double[,,] _velocityXArray;
    private readonly double[,,] _velocityYArray;
    private readonly double[,,] _velocityZArray;
    private readonly double[,,] _tempMassArray;
    private double[,,] _temperatureVolume;
    private double _darkEnergyEffect;
    private double _totalEnergy;




    public INoiseAlgorithm NoiseAlgorithm;
    public IInterpolationAlgorithm InterpolationAlgorithm;
    public INoiseAlgorithm TemperatureNoiseAlgorithm;
    public double InitialRadiationStrength = 2.0;
    public double RadiationDecayRate = 0.05;
    public double BaryonicFeedbackThreshold { get; set; } = 1.2;
    public double BaryonicFeedbackStrength { get; set; } = 0.1;
    public double BaryonicFeedbackSpread { get; set; } = 0.5;
    public double TemperatureFluctuationRange = 0.05;
    public double BaseCoolingRate { get; set; } = 0.01;
    public double BaseHeatingRate { get; set; } = 0.1;
    public double CoolingRateDensityFactor { get; set; } = 0.05;
    public double HeatingRateDensityFactor { get; set; } = 0.02;
    public double CollisionalCoolingFactor { get; set; } = 0.02;
    public double CollisionalHeatingFactor { get; set; } = 0.01;
    public double StellarFormationMinimumDensityThreshold { get; set; } = 1.5;
    public double StellarFormationRate { get; set; } = 0.05; // Fraction of gas converted to stars
    public double MergingThreshold { get; set; } = 2.0;
    public int MergingRadius { get; set; } = 2;
    public double GalacticFeedbackThreshold { get; set; } = 2.5;
    public double GalacticFeedbackEnergy { get; set; } = 1.0;
    public double DensityThreshold { get; set; } = 0.2;
    public double StructureThreshold { get; set; } = 0.5;
    public double Sigma = 0.5;
    public double InitialHydrogenPercentage = 75.0;
    public double InitialHeliumPercentage = 25.0;
    public double InitialMetalPercentage = 0.0;
    public double StarFormationMaximumTemperatureThreshold = 10.0;
    public double ShockHeatingMinimumDensityThreshold = 0.5;
    public double TimeStep = 1;
    public double PercentOfStarMassConvertedToMetals = 2.0;
    public double PercentOfStarMassRetainedAsHydrogen = 98.0;
    public double TemperatureIncreaseDueToShockHeating = 10.0;
    public int MaxEffectiveRangeOfGravity = 1;
    public int MaxEffectiveRangeOfRadiation = 1;




    private void GenerateCosmicWebByEvolution(CosmicWeb self)
    {
        _darkEnergyEffect = Math.Pow(1 + Context.DarkEnergyPercentage / 100.0, 0.5) - 1;

        InitializeVolumes();

        double currentTime = 0;

        while (currentTime < Context.Age)
        {
            ApplyGravity(currentTime);
            UpdateVelocitiesBasedOnForces(currentTime);
            ApplyRadiation(currentTime);
            ApplyBaryonicFeedback(currentTime);
            ApplyStarFormationAndChemicalEvolution(currentTime);
            ApplyHeatingAndCooling(currentTime);
            ApplyInteractions(currentTime);
            ApplyMerging();
            ApplyGalacticFeedback(currentTime);
            ApplyExpansion(currentTime);
            AdvectMass(currentTime);
            HandleBoundaries();

            currentTime += TimeStep;
        }

        var smoothedVolume = VolumeProcessing.ApplyGaussianSmoothing(_baryonicVolume, Sigma);
        IdentifyStructures(smoothedVolume);

        var labels = LabelConnectedComponents(smoothedVolume, StructureThreshold);
        var extractedRegions = ExtractLabeledRegions(labels);
    }

    private void InitializeVolumes()
    {
        _baryonicVolume = new double[Context.MapX, Context.MapY, Context.MapZ];
        _darkMatterVolume = new double[Context.MapX, Context.MapY, Context.MapZ];
        _temperatureVolume = new double[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            var totalNoise = NoiseAlgorithm.GenerateSingleSample();

            _baryonicVolume[i, j, k] = totalNoise * Context.BaryonicMatterPercentage / 100.0;
            _darkMatterVolume[i, j, k] = totalNoise * Context.DarkMatterPercentage / 100.0;
            var temperatureNoise = TemperatureNoiseAlgorithm.GenerateSingleSample(); // Assumed to be in range [-1, 1]
            var temperatureFluctuation = temperatureNoise * TemperatureFluctuationRange;
            _temperatureVolume[i, j, k] = Context.CosmicMicrowaveBackground + temperatureFluctuation;
            var totalBaryonicDensity = _baryonicVolume[i, j, k];
            _hydrogenVolume[i, j, k] = InitialHydrogenPercentage / 100 * totalBaryonicDensity;
            _heliumVolume[i, j, k] = InitialHeliumPercentage / 100 * totalBaryonicDensity;
            _metalVolume[i, j, k] = InitialMetalPercentage / 100 * totalBaryonicDensity;
            _massArray[i, j, k] = _baryonicVolume[i, j, k] + _darkMatterVolume[i, j, k];
            _totalEnergy += _temperatureVolume[i, j, k];
        });
    }

    private void UpdateVelocitiesBasedOnForces(double timeStep)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            double accelerationX = 0;
            double accelerationY = 0;
            double accelerationZ = 0;

            VolumeFunctions.RunNeighborFunction(-1, 1, (int dx, int dy, int dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz) || (dx == 0 && dy == 0 && dz == 0)) return;
                var aGravity = AdvancedSettings.PhysicalConstants.G * _massArray[i + dx, j + dy, k + dz];
                accelerationX += dx == 0 ? 0 : (dx / Math.Abs(dx)) * aGravity;
                accelerationY += dy == 0 ? 0 : (dy / Math.Abs(dy)) * aGravity;
                accelerationZ += dz == 0 ? 0 : (dz / Math.Abs(dz)) * aGravity;
            });

            _velocityXArray[i, j, k] += accelerationX * timeStep;
            _velocityYArray[i, j, k] += accelerationY * timeStep;
            _velocityZArray[i, j, k] += accelerationZ * timeStep;
        });
    }

    private void AdvectMass(double timeStep)
    {
        Array.Copy(_massArray, _tempMassArray, _massArray.Length);

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
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
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            if (i != 0 && i != Context.MapX - 1 &&
                j != 0 && j != Context.MapY - 1 &&
                k != 0 && k != Context.MapZ - 1) return;

            _totalEnergy -= _massArray[i, j, k] * _temperatureVolume[i, j, k];
            _massArray[i, j, k] = 0;
            _temperatureVolume[i, j, k] = 0;
        });
    }

    private void ApplyGalacticFeedback(double timeInYears)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            if (_baryonicVolume[i, j, k] <= GalacticFeedbackThreshold) return;

            var energyReductionFromDensity = GalacticFeedbackEnergy * timeInYears;
            var energyIncreaseFromTemperature = GalacticFeedbackEnergy * timeInYears;

            _totalEnergy -= energyReductionFromDensity;
            _totalEnergy += energyIncreaseFromTemperature;

            _baryonicVolume[i, j, k] -= energyReductionFromDensity;
            _temperatureVolume[i, j, k] += energyIncreaseFromTemperature;

            VolumeFunctions.RunNeighborFunction(-1, 1, (int dx, int dy, int dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;

                var localEnergyReduction = GalacticFeedbackEnergy * timeInYears / 3;
                var localEnergyIncrease = GalacticFeedbackEnergy * timeInYears / 3;

                _totalEnergy -= localEnergyReduction;
                _totalEnergy += localEnergyIncrease;

                _baryonicVolume[i + dx, j + dy, k + dz] -= localEnergyReduction;
                _temperatureVolume[i + dx, j + dy, k + dz] += localEnergyIncrease;
            });
        });
    }

    private void ApplyStarFormationAndChemicalEvolution(double timeInYears)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            if (_baryonicVolume[i, j, k] <= StellarFormationMinimumDensityThreshold || _temperatureVolume[i, j, k] >= StarFormationMaximumTemperatureThreshold) return;
            var starsFormed = StellarFormationRate * _baryonicVolume[i, j, k] * timeInYears;

            _totalEnergy -= starsFormed;
            _baryonicVolume[i, j, k] -= starsFormed;

            var metalFormed = PercentOfStarMassConvertedToMetals / 100 * starsFormed;
            _metalVolume[i, j, k] += metalFormed;
            _totalEnergy += metalFormed;

            var hydrogenFormed = PercentOfStarMassRetainedAsHydrogen / 100 * starsFormed;
            _hydrogenVolume[i, j, k] -= hydrogenFormed;
            _totalEnergy -= hydrogenFormed;
        });
    }

    private void ApplyMerging()
    {
        var changeInMass = new double[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            if (_baryonicVolume[i, j, k] <= MergingThreshold) return;

            var excessMass = _baryonicVolume[i, j, k] - MergingThreshold;
            changeInMass[i, j, k] -= excessMass;

            var countNeighbors = 0;

            VolumeFunctions.RunNeighborFunction(-MergingRadius, MergingRadius, (int dx, int dy, int dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
                countNeighbors++;
            });

            VolumeFunctions.RunNeighborFunction(-MergingRadius, MergingRadius, (int dx, int dy, int dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
                changeInMass[i + dx, j + dy, k + dz] += excessMass / countNeighbors;
            });
        });

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) => { _baryonicVolume[i, j, k] = Math.Max(0, _baryonicVolume[i, j, k] + changeInMass[i, j, k]); });
    }

    private void ApplyInteractions(double timeInYears)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            if (_baryonicVolume[i, j, k] > StellarFormationMinimumDensityThreshold && _temperatureVolume[i, j, k] < StarFormationMaximumTemperatureThreshold)
            {
                var starsFormed = StellarFormationRate * _baryonicVolume[i, j, k] * timeInYears;
                _baryonicVolume[i, j, k] -= starsFormed;
            }

            var densityGradient = CalculateDensityGradient(i, j, k);
            if (densityGradient > ShockHeatingMinimumDensityThreshold) 
            {
                _temperatureVolume[i, j, k] += TemperatureIncreaseDueToShockHeating;
            }
        });
    }

    private double CalculateDensityGradient(int i, int j, int k)
    {
        double gradient = 0;

        VolumeFunctions.RunNeighborFunction(-1, 1, (int dx, int dy, int dz) =>
        {
            if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
            gradient += Math.Abs(_baryonicVolume[i + dx, j + dy, k + dz] - _baryonicVolume[i, j, k]);
        });

        // Normalize by number of neighbors (for a 3x3x3 cube it's 27 cells minus the center cell)
        gradient /= 26.0;
        return gradient;
    }

    private void ApplyGravity(double timeInYears)
    {

        var updatedBaryonicVolume = new double[Context.MapX, Context.MapY, Context.MapZ];
        var updatedDarkMatterVolume = new double[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            double gravitationalEffectBaryonic = 0;
            double gravitationalEffectDarkMatter = 0;

            VolumeFunctions.RunNeighborFunction(-MaxEffectiveRangeOfGravity, MaxEffectiveRangeOfGravity, (int dx, int dy, int dz) =>
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

    private void ApplyRadiation(double timeInYears, int range = 1)
    {
        var currentRadiationStrength = InitialRadiationStrength * Math.Exp(-RadiationDecayRate * timeInYears);

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            double radiationEffect = 0;

            VolumeFunctions.RunNeighborFunction(-range, range, (int dx, int dy, int dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz)) return;
                double distanceSquared = dx * dx + dy * dy + dz * dz;
                if (distanceSquared == 0) return;

                radiationEffect -= currentRadiationStrength * _baryonicVolume[i + dx, j + dy, k + dz] / distanceSquared;
            });

            _baryonicVolume[i, j, k] += radiationEffect * timeInYears;
        });
    }

    private void ApplyExpansion(double timeInYears)
    {
        var expansionFactor = 1.0 + (Context.ExpansionRate * 3.15e7 * 2.09e5 + _darkEnergyEffect) * timeInYears;
        _baryonicVolume = VolumeProcessing.InterpolateVolume(_baryonicVolume, expansionFactor, InterpolationAlgorithm);
        _darkMatterVolume = VolumeProcessing.InterpolateVolume(_darkMatterVolume, expansionFactor, InterpolationAlgorithm);
    }

    private void ApplyBaryonicFeedback(double timeInYears)
    {
        var feedbackEffects = new double[Context.MapX, Context.MapY, Context.MapZ];
        var energyInjected = new double[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            if (!(_baryonicVolume[i, j, k] > BaryonicFeedbackThreshold)) return;
            var feedback = BaryonicFeedbackStrength * timeInYears;
            _baryonicVolume[i, j, k] -= feedback;
            feedbackEffects[i, j, k] = feedback * BaryonicFeedbackSpread;

            var energyChange = BaseHeatingRate * timeInYears;
            _temperatureVolume[i, j, k] += energyChange;
            energyInjected[i, j, k] = energyChange;
        });

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            if (!(feedbackEffects[i, j, k] > 0)) return;

            VolumeFunctions.RunNeighborFunction(-1, 1, (int dx, int dy, int dz) =>
            {
                if (!IsWithinBounds(i + dx, j + dy, k + dz) || dx == 0 && dy == 0 && dz == 0) return;
                _baryonicVolume[i + dx, j + dy, k + dz] += feedbackEffects[i, j, k] / 26.0;
                _temperatureVolume[i + dx, j + dy, k + dz] += energyInjected[i, j, k] / 26.0;
            });
        });
    }

    private void ApplyHeatingAndCooling(double timeInYears)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            var localDensity = _baryonicVolume[i, j, k];
            var effectiveCoolingRate = BaseCoolingRate * (1 + CoolingRateDensityFactor * localDensity);
            var effectiveHeatingRate = BaseHeatingRate * (1 - HeatingRateDensityFactor * localDensity);
            effectiveCoolingRate += CollisionalCoolingFactor * localDensity * localDensity;
            effectiveHeatingRate += CollisionalHeatingFactor * localDensity * localDensity;

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
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            var density = smoothedVolume[i, j, k];

            if (density < DensityThreshold)
            {
                // Void
                return;
            }

            if (density < StructureThreshold)
            {
                // Uninteresting region, can skip or label accordingly
                return;
            }

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
                default:
                    // Other, or you can classify as void
                    break;
            }
        });
    }

    private int[,,] LabelConnectedComponents(double[,,] structureVolume, double threshold)
    {
        var labels = new int[Context.MapX, Context.MapY, Context.MapZ];
        var currentLabel = 1;

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (int i, int j, int k) =>
        {
            if (!(structureVolume[i, j, k] > threshold) || labels[i, j, k] != 0) return;
            VolumeProcessing.FloodFill(structureVolume, labels, i, j, k, currentLabel, threshold);
            currentLabel++;
        });

        return labels;
    }

    private Dictionary<int, List<(int x, int y, int z)>> ExtractLabeledRegions(int[,,] labels)
    {
        var regions = new Dictionary<int, List<(int x, int y, int z)>>();

        for (var i = 0; i < labels.GetLength(0); i++)
        {
            for (var j = 0; j < labels.GetLength(1); j++)
            {
                for (var k = 0; k < labels.GetLength(2); k++)
                {
                    var label = labels[i, j, k];
                    if (label <= 0) continue;
                    if (!regions.ContainsKey(label))
                    {
                        regions[label] = new List<(int x, int y, int z)>();
                    }

                    regions[label].Add((i, j, k));
                }
            }
        }

        return regions;
    }
}