using System.Numerics;
using VNet.Mathematics.LinearAlgebra.Matrix;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.Scientific.NumericalVolumes;
using VNet.System.Events;
// ReSharper disable AccessToModifiedClosure
// ReSharper disable SuggestBaseTypeForParameter
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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
    private double[,,] _darkMatterVolume;
    private double[,,] _temperatureVolume;
    private double _totalEnergy;


    private void GenerateCosmicWebByEvolution(CosmicWebContext context, CosmicWeb self)
    {
        InitializeVolumes();

        double currentTime = 0;

        while (currentTime < Context.Age)
        {
            ApplyBaryonicGravity(context, self, currentTime);
            ApplyDarkMatterGravity(context, self, currentTime);
            UpdateVelocitiesBasedOnForces(context, self, currentTime);
            ApplyRadiation(context, self, currentTime);
            ApplyBaryonicFeedback(context, self, currentTime);
            ApplyStarFormationAndChemicalEvolution(context, self, currentTime);
            ApplyHeatingAndCooling(context, self, currentTime);
            ApplyShockHeating(context, self, currentTime);
            ApplyMerging();
            ApplyGalacticFeedback(context, self, currentTime);
            AdvectMass(context, self, currentTime);
            ApplyDarkEnergy(context, self, currentTime);
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
            // CalculateDensityGradient now returns a Vector3 representing the gradient.
            var densityGradientVector = CalculateDensityGradient(i, j, k);

            // Calculate the magnitude of the density gradient vector.
            // This represents the rate of change of the density field, ignoring the direction.
            var densityGradientMagnitude = densityGradientVector.Length(); // or .Magnitude, depending on the Vector3 implementation

            // Compare the magnitude against the threshold to determine if shock heating should be applied.
            if (densityGradientMagnitude > AdvancedSettings.Objects.CosmicWeb.EvolutionShockHeatingMinimumDensityThreshold)
            {
                // If the gradient's magnitude is above the threshold, increase the temperature.
                _temperatureVolume[i, j, k] += AdvancedSettings.Objects.CosmicWeb.EvolutionTemperatureIncreaseDueToShockHeating;
            }
        });
    }


    private Vector3 CalculateDensityGradient(int i, int j, int k)
    {
        // Initialize partial derivatives.
        var dDensity_dx = 0.0;
        var dDensity_dy = 0.0;
        var dDensity_dz = 0.0;

        // Check the bounds before accessing the array elements.
        // This avoids IndexOutOfRangeException for the border elements.
        var isXInBounds = i > 0 && i < Context.MapX - 1;
        var isYInBounds = j > 0 && j < Context.MapY - 1;
        var isZInBounds = k > 0 && k < Context.MapZ - 1;

        // Compute partial derivatives. 
        // The gradient vector points in the direction of greatest rate of increase of the density function.
        if (isXInBounds)
        {
            dDensity_dx = (_baryonicVolume[i + 1, j, k] - _baryonicVolume[i - 1, j, k]) / 2.0;
        }
        if (isYInBounds)
        {
            dDensity_dy = (_baryonicVolume[i, j + 1, k] - _baryonicVolume[i, j - 1, k]) / 2.0;
        }
        if (isZInBounds)
        {
            dDensity_dz = (_baryonicVolume[i, j, k + 1] - _baryonicVolume[i, j, k - 1]) / 2.0;
        }

        // Construct the gradient vector from the partial derivatives.
        var gradient = new Vector3((float)dDensity_dx, (float)dDensity_dy, (float)dDensity_dz);

        return gradient; // This is now a vector that includes directionality information.
    }


    private void ApplyBaryonicGravity(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        var deltaPositionsBaryonic = new Vector3[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            var netForceBaryonic = new Vector3();

            VolumeFunctions.RunNeighborFunction(-AdvancedSettings.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfGravity,
                                                AdvancedSettings.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfGravity, (dx, dy, dz) =>
                {
                    int newX = i + dx, newY = j + dy, newZ = k + dz;
                    if (!IsWithinBounds(newX, newY, newZ)) return;

                    double distanceSquared = dx * dx + dy * dy + dz * dz;
                    if (distanceSquared <= 0.0001) return; // Avoiding singularities

                    var direction = new Vector3(dx, dy, dz);
                    direction = Vector3.Normalize(direction);

                    var massProduct = (_baryonicVolume[newX, newY, newZ] * _baryonicVolume[i, j, k]) > 0
                                     ? (_baryonicVolume[newX, newY, newZ] * _baryonicVolume[i, j, k])
                                     : 1;

                    // Apply the inverse-square law here
                    var forceMagnitude = AdvancedSettings.PhysicalConstants.G * massProduct / distanceSquared;

                    var gravitationalForce = direction * (float)forceMagnitude;
                    netForceBaryonic += gravitationalForce;
                });

            var mass = _baryonicVolume[i, j, k] > 0 ? (float)_baryonicVolume[i, j, k] : 1;
            var acceleration = netForceBaryonic / mass;

            deltaPositionsBaryonic[i, j, k] = 0.5f * acceleration * (float)(timeInYears * timeInYears * 1E7); // Adjusted for cosmic scale.
        });

        // Update the actual volumes based on the calculated position changes.
        ApplyMovements(context, self, _baryonicVolume, deltaPositionsBaryonic);
        // Other properties like velocity, temperature, etc., should also be updated here based on the specific rules of your simulation.

        ApplyMovements(context, self, _heliumVolume, deltaPositionsBaryonic);
        ApplyMovements(context, self, _hydrogenVolume, deltaPositionsBaryonic);
        ApplyMovements(context, self, _massArray, deltaPositionsBaryonic);
        ApplyMovements(context, self, _metalVolume, deltaPositionsBaryonic);
        ApplyMovements(context, self, _tempMassArray, deltaPositionsBaryonic);
        ApplyMovements(context, self, _velocityXArray, deltaPositionsBaryonic);
        ApplyMovements(context, self, _velocityYArray, deltaPositionsBaryonic);
        ApplyMovements(context, self, _velocityZArray, deltaPositionsBaryonic);
        ApplyMovements(context, self, _baryonicVolume, deltaPositionsBaryonic);
        ApplyMovements(context, self, _darkMatterVolume, deltaPositionsBaryonic);
        AdjustTemperatureVolume(context, self, timeInYears);
        //ApplyMovements(context, self, _temperatureVolume, deltaPositionsBaryonic);
    }

    private void AdjustTemperatureVolume(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            var currentTemperature = _temperatureVolume[i, j, k];

            currentTemperature *= 1.0 - (self.Universe.ExpansionRate * timeInYears);

            var gravitationalHeatingFactor = CalculateGravitationalHeating(i, j, k);
            _temperatureVolume[i, j, k] = currentTemperature;

            if (_temperatureVolume[i, j, k] < self.Universe.CosmicMicrowaveBackground)
            {
                _temperatureVolume[i, j, k] = self.Universe.CosmicMicrowaveBackground;
            }
        });
    }

    private double CalculateGravitationalHeating(int i, int j, int k)
    {
        var massDensity = GetMassDensity(i, j, k);
        var potentialEnergy = massDensity * AdvancedSettings.PhysicalConstants.G;
        var efficiencyFactor = Settings.Advanced.Objects.CosmicWeb.GravitationalHeatingEfficiencyPercent / 100;
        var heating = efficiencyFactor * potentialEnergy;

        return heating;
    }

    private double GetMassDensity(int x, int y, int z)
    {
        if (x < 0 || x >= Context.MapX || y < 0 || y >= Context.MapY || z < 0 || z >= Context.MapZ)
        {
            throw new ArgumentOutOfRangeException();
        }

        var baryonicVolume = _baryonicVolume[x, y, z];
        var darkMatterVolume = _darkMatterVolume[x, y, z];
        var totalMass = baryonicVolume + darkMatterVolume;

        return totalMass;
    }

    private void ApplyDarkMatterGravity(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        var deltaPositionsDarkMatter = new Vector3[Context.MapX, Context.MapY, Context.MapZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            var netForceDarkMatter = new Vector3();

            VolumeFunctions.RunNeighborFunction(-AdvancedSettings.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfGravity, AdvancedSettings.Objects.CosmicWeb.EvolutionMaxEffectiveRangeOfGravity, (dx, dy, dz) =>
            {
                var newX = i + dx;
                var newY = j + dy;
                var newZ = k + dz;

                if (!IsWithinBounds(newX, newY, newZ)) return;

                double distanceSquared = dx * dx + dy * dy + dz * dz;
                if (distanceSquared < 0.0001) return; // Avoiding singularities

                var forceDirection = new Vector3(dx, dy, dz);
                forceDirection = Vector3.Normalize(forceDirection);

                var massDensity = GetMassDensity(newX, newY, newZ);

                // Apply the inverse-square law here
                var gravitationalForceMagnitude = AdvancedSettings.PhysicalConstants.G * massDensity / distanceSquared;
                var gravitationalForce = forceDirection * (float)gravitationalForceMagnitude;

                netForceDarkMatter += gravitationalForce;
            });

            var massDensityAtCurrent = GetMassDensity(i, j, k);
            var accelerationDarkMatter = netForceDarkMatter / (float)(massDensityAtCurrent > 0 ? massDensityAtCurrent : 1); // Avoid division by zero
            deltaPositionsDarkMatter[i, j, k] = 0.5f * accelerationDarkMatter * (float)(timeInYears * timeInYears);
        });

        ApplyMovements(context, self, _heliumVolume, deltaPositionsDarkMatter);
        ApplyMovements(context, self, _hydrogenVolume, deltaPositionsDarkMatter);
        ApplyMovements(context, self, _massArray, deltaPositionsDarkMatter);
        ApplyMovements(context, self, _metalVolume, deltaPositionsDarkMatter);
        ApplyMovements(context, self, _tempMassArray, deltaPositionsDarkMatter);
        ApplyMovements(context, self, _velocityXArray, deltaPositionsDarkMatter);
        ApplyMovements(context, self, _velocityYArray, deltaPositionsDarkMatter);
        ApplyMovements(context, self, _velocityZArray, deltaPositionsDarkMatter);
        ApplyMovements(context, self, _baryonicVolume, deltaPositionsDarkMatter);
        ApplyMovements(context, self, _darkMatterVolume, deltaPositionsDarkMatter);
        AdjustTemperatureVolume(context, self, timeInYears);
    }

    private void ApplyMovements(CosmicWebContext context, CosmicWeb self, double[,,] volumeMap, Vector3[,,] deltaPositions)
    {
        var sizeX = self.Universe.DimensionX;
        var sizeY = self.Universe.DimensionY;
        var sizeZ = self.Universe.DimensionZ;

        var newVolumeMap = new double[sizeX, sizeY, sizeZ];

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {
            var newX = (int)Math.Round(i + deltaPositions[i, j, k].X);
            var newY = (int)Math.Round(j + deltaPositions[i, j, k].Y);
            var newZ = (int)Math.Round(k + deltaPositions[i, j, k].Z);

            if (newX >= 0 && newX < sizeX && newY >= 0 && newY < sizeY && newZ >= 0 && newZ < sizeZ)
            {
                newVolumeMap[newX, newY, newZ] += volumeMap[i, j, k];
            }
            else
            {
                newVolumeMap[i, j, k] += volumeMap[i, j, k];
            }
        });

        Array.Copy(newVolumeMap, volumeMap, newVolumeMap.Length);
    }

    private void ApplyDarkEnergy(CosmicWebContext context, CosmicWeb self, double timeInYears)
    {
        var universalExpansionDeltas = new Vector3[Context.MapX, Context.MapY, Context.MapZ];
        var expansionRate = (float)self.Universe.ExpansionRate;

        VolumeFunctions.RunVolumeFunction(Context.MapX, Context.MapY, Context.MapZ, (i, j, k) =>
        {

            universalExpansionDeltas[i, j, k] = new Vector3(i, j, k) * expansionRate * (float)timeInYears;
        });

        ApplyMovements(context, self, _heliumVolume, universalExpansionDeltas);
        ApplyMovements(context, self, _hydrogenVolume, universalExpansionDeltas);
        ApplyMovements(context, self, _massArray, universalExpansionDeltas);
        ApplyMovements(context, self, _metalVolume, universalExpansionDeltas);
        ApplyMovements(context, self, _tempMassArray, universalExpansionDeltas);
        ApplyMovements(context, self, _velocityXArray, universalExpansionDeltas);
        ApplyMovements(context, self, _velocityYArray, universalExpansionDeltas);
        ApplyMovements(context, self, _velocityZArray, universalExpansionDeltas);
        ApplyMovements(context, self, _baryonicVolume, universalExpansionDeltas);
        ApplyMovements(context, self, _darkMatterVolume, universalExpansionDeltas);
        AdjustTemperatureVolume(context, self, timeInYears);
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

    //private void ApplyExpansion(CosmicWebContext context, CosmicWeb self, double timeInYears)
    //{
    //    _baryonicVolume = VolumeProcessing.InterpolateVolume(_baryonicVolume, self.Universe.ExpansionRate, AdvancedSettings.Objects.CosmicWeb.EvolutionInterpolationAlgorithm);
    //    _darkMatterVolume = VolumeProcessing.InterpolateVolume(_darkMatterVolume, self.Universe.ExpansionRate, AdvancedSettings.Objects.CosmicWeb.EvolutionInterpolationAlgorithm);
    //}


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