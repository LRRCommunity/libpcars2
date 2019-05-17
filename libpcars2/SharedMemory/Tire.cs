// <copyright file="Tire.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System;

namespace LibPCars2.SharedMemory
{
    /// <summary>
    /// Holds information about each of a car's tires.
    /// </summary>
    public class Tire
    {
#pragma warning disable SA1516
#pragma warning disable SA1600
        public TireFlags TireFlags { get; internal set; }
        public TerrainType Terrain { get; internal set; }
        public string TireCompound { get; internal set; }

        public float YPosition { get; internal set; }
        public float RotationsPerSecond { get; internal set; }
        public float Temperature { get; internal set; }
        public float HeightAboveGround { get; internal set; }

        public float TireWear { get; internal set; }
        public float BrakeDamage { get; internal set; }
        public float SuspensionDamage { get; internal set; }

        public float BrakeTemp { get; internal set; }
        public float TreadTemp { get; internal set; }
        public float LayerTemp { get; internal set; }
        public float CarcassTemp { get; internal set; }
        public float RimTemp { get; internal set; }
        public float InternalAirTemp { get; internal set; }

        public float LocalPosition { get; internal set; }
        public float SuspensionTravel { get; internal set; }
        public float SuspensionVelocity { get; internal set; }
        public float AirPressure { get; internal set; }

        [Obsolete]
        public float SlipSpeed { get; internal set; }
        [Obsolete]
        public float Grip { get; internal set; }
        [Obsolete]
        public float LateralStiffness { get; internal set; }
    }
}
