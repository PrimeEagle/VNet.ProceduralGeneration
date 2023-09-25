﻿namespace VNet.ProceduralGeneration.Cosmological;

public class SupernovaGenerator : IGeneratable<Supernova, SupernovaContext>
{
    public Supernova Generate(SupernovaContext context)
    {
        var supernova = new Supernova
        {
            // ... Generate properties specific to Supernova
        };
        return supernova;
    }
}