using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;
// ReSharper disable MemberCanBeMadeStatic.Local
#pragma warning disable CA1822

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class GroupGeneratorBase<T, TContext> : GeneratorBase<T, TContext>, IDisposable
                                                        where T : AstronomicalObjectGroup, new()
                                                        where TContext : GroupContextBase
{
    protected GroupGeneratorBase(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected abstract void GenerateWarpedSurface(TContext context, T self);
    protected abstract void GenerateInteriorObjects(TContext context, T self);
    protected abstract void GenerateInteriorRandomizationAlgorithm(TContext context, T self);
    protected abstract void GenerateSurfaceNoiseAlgorithm(TContext context, T self);
    protected override void GenerateBaseProperties(TContext context, T self)
    {
        SetMatterType(context, self);
        GenerateDiameter(context, self);
        GeneratePosition(context, self);
        GenerateOrientation(context, self);
        GenerateBoundingBox(context, self);
        GenerateSurfaceNoiseAlgorithm(context, self);
        GenerateInteriorRandomizationAlgorithm(context, self);
        GenerateWarpedSurface(context, self);
        GenerateInteriorObjects(context, self);
    }

    protected virtual void ApplyGravitationalEffectsToInterior(TContext context, T self, float timeInYears)
    {
        if (!Settings.Basic.ApplyGravitationalEffects) return;

        var objectCount = self.InteriorObjects.Count;
        var interactions = new InteractionData[objectCount, objectCount];

        for (var i = 0; i < objectCount; i++)
        {
            for (var j = i + 1; j < objectCount; j++)
            {
                var direction = self.InteriorObjects[j].Position - self.InteriorObjects[i].Position;
                interactions[i, j] = new InteractionData
                {
                    Direction = Vector3.Normalize(direction),
                    Distance = direction.Length()
                };

                interactions[j, i] = new InteractionData
                {
                    Direction = -interactions[i, j].Direction,
                    Distance = interactions[i, j].Distance // the distance is the same
                };
            }
        }

        var netDisplacements = new Vector3[objectCount];
        var netVelocities = new Vector3[objectCount];

        Parallel.For(0, objectCount, i =>
        {
            for (var j = 0; j < objectCount; j++)
            {
                if (i == j) continue;

                var interaction = interactions[i, j];
                var force = CalculateGravitationalForce(self.InteriorObjects[i], self.InteriorObjects[j], interaction.Distance);

                if (Settings.Advanced.Application.ApplyGravitationalEffectsApplyDarkEnergy)
                {
                    force = ApplyDarkEnergyEffects(force, self, i, j, timeInYears, interaction.Direction, interaction.Distance);
                }

                var (velocityChange, displacementChange) = CalculateMovementChanges(force, self.InteriorObjects[i].Mass, timeInYears, interaction.Direction);

                netVelocities[i] += velocityChange;
                netDisplacements[i] += displacementChange;
            }
        });

        UpdateObjectPositions(self, netDisplacements);
    }

    private double CalculateGravitationalForce(IUndefinedAstronomicalObject object1, IUndefinedAstronomicalObject object2, float distance)
    {
        if (Settings.Advanced.Application.ApplyGravitationalEffectsPreventDarkMatterClumping &&
            object1.MatterType == MatterType.DarkMatter &&
            object2.MatterType == MatterType.DarkMatter &&
            distance < Settings.Advanced.Application.MinimumDarkMatterDistanceToPreventClumping)
        {
            distance = Settings.Advanced.Application.MinimumDarkMatterDistanceToPreventClumping;
        }

        return Settings.Advanced.PhysicalConstants.G * object1.Mass * object2.Mass / (distance * distance);
    }

    private double ApplyDarkEnergyEffects(double force, T self, int i, int j, float timeInYears, Vector3 direction, float distance)
    {
        var darkEnergyInfluence = self.Universe.DarkEnergyPercent * distance * self.Universe.ExpansionRate * timeInYears;
        var darkEnergyForce = direction * (float)darkEnergyInfluence;

        return force - darkEnergyForce.Length();
    }

    private (Vector3, Vector3) CalculateMovementChanges(double force, double mass, float timeInYears, Vector3 direction)
    {
        var acceleration = force / mass;
        var velocity = acceleration * timeInYears;
        var displacement = 0.5f * acceleration * timeInYears * timeInYears;

        if (Settings.Advanced.Application.ApplyGravitationalEffectsDampenBaryonicMatter)
        {
            velocity *= Settings.Advanced.Application.BaryonicMatterDampeningFactor;
        }

        return (Vector3.Multiply(direction, (float)velocity), Vector3.Multiply(direction, (float)displacement));
    }

    private void UpdateObjectPositions(T self, IReadOnlyList<Vector3> netDisplacements)
    {
        for (var i = 0; i < self.InteriorObjects.Count; i++)
        {
            self.InteriorObjects[i].Position += netDisplacements[i];
        }
    }

    protected override void PostProcess(TContext context, T self)
    {
        ApplyGravitationalEffectsToInterior(context, self, self.Age);
    }

    protected bool PointsOverlap(IEnumerable<IUndefinedAstronomicalObject> points, IUndefinedAstronomicalObject newPoint)
    {
        return points.Any(i => Vector3.Distance(i.Position, newPoint.Position) < Settings.Advanced.Application.InteriorObjectOverlapThreshold);
    }
}