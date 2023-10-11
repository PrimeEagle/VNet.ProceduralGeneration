﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public abstract class FilamentGeneratorBase<T, TContext> : ContainerGeneratorBase<T, TContext>, IDisposable
                                                 where T : AstronomicalObjectContainer, new()
                                                 where TContext : ContextBase
    {

        protected FilamentGeneratorBase(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
        {
        }
    }
}