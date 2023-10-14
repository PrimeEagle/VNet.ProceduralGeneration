﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class FermiBubbleGenerator : GeneratorBase<FermiBubble, FermiBubbleContext>
{
    public FermiBubbleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<FermiBubble> GenerateSelf(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }
}