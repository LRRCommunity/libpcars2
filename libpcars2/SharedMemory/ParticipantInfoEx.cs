// <copyright file="ParticipantInfoEx.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace LibPCars2.SharedMemory
{
#pragma warning disable SA1516
#pragma warning disable SA1600
#pragma warning disable SA1601
    public class ParticipantInfoEx
    {
        public float CurrentSector1Time { get; internal set; }
        public float CurrentSector2Time { get; internal set; }
        public float CurrentSector3Time { get; internal set; }

        public float FastestSector1Time { get; internal set; }
        public float FastestSector2Time { get; internal set; }
        public float FastestSector3Time { get; internal set; }

        public float FastestLapTime { get; internal set; }
        public float LastLapTime { get; internal set; }
        public bool InvalidLap { get; internal set; }

        public RaceState RaceState { get; internal set; }
        public Vector3 Orientation { get; internal set; }
        public float Speed { get; internal set; }

        public PitMode PitMode { get; internal set; }
        public PitSchedule PitSchedule { get; internal set; }

        public FlagColor HighestFlagColor { get; internal set; }
        public FlagReason HighestFlagReason { get; internal set; }

        public string CarName { get; internal set; }
        public string CarClassName { get; internal set; }
        public uint CountryCode { get; internal set; }
    }
}
