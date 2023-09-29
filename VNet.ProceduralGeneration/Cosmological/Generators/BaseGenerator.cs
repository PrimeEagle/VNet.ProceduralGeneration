using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological
{
    public abstract class BaseGenerator<T, TContext> : IGeneratable<T, TContext> where T : AstronomicalObject
                                                                                 where TContext : BaseContext
    {
        protected readonly GeneratorConfig config;


        public abstract T Generate(TContext context);

        public BaseGenerator(GeneratorConfig config)
        {
            this.config = config;
        }
    }
}