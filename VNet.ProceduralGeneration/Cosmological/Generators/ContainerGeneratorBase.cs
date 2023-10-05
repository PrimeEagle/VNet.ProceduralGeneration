using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public abstract class ContainerGeneratorBase<T, TContext> : GeneratorBase<T, TContext>, IDisposable
                                                      where T : AstronomicalObjectContainer, new()
                                                      where TContext : ContextBase
    {

        protected ContainerGeneratorBase(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
        {
        }

        protected override void GenerateAge(TContext context, T self)
        {
            throw new NotImplementedException();
        }

        protected override void GenerateLifespan(TContext context, T self)
        {
            throw new NotImplementedException();
        }

        protected override void GenerateLuminosity(TContext context, T self)
        {
            throw new NotImplementedException();
        }

        protected override void GenerateTemperature(TContext context, T self)
        {
            throw new NotImplementedException();
        }

        protected override void GenerateMass(TContext context, T self)
        {
            throw new NotImplementedException();
        }

        protected override void GenerateBaseProperties(TContext context, T self)
        {
            GenerateDiameter(context, self);
            GeneratePosition(context, self);
        }
    }
}