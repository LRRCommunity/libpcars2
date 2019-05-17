// <copyright file="TelemetryData.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System.Numerics;

namespace LibPCars2.SharedMemory
{
#pragma warning disable SA1516
#pragma warning disable SA1600
#pragma warning disable SA1601
    public partial class TelemetryData
    {
        public GameState GameState { get; }
        public SessionState SessionState { get; }
        public RaceState RaceState { get; }

        public uint SequenceNumber { get; }

        public int ViewedParticipantIndex { get; }
        public int NumParticipants { get; }
        public ParticipantInfo[] Participants { get; }
        public ParticipantInfoEx[] ParticipantsEx { get; }

        public float Brake { get; }
        public float Clutch { get; }
        public float Steering { get; }
        public float Throttle { get; }
        public float UnfilteredBrake { get; }
        public float UnfilteredClutch { get; }
        public float UnfilteredSteering { get; }
        public float UnfilteredThrottle { get; }

        public string CarName { get; }
        public string CarClassName { get; }

        public EventInfo EventDetails { get; }
        public WeatherInfo Weather { get; }

        public bool InvalidLap { get; }
        public float BestLapTime { get; }
        public float LastLapTime { get; }
        public float CurrentTime { get; }
        public float SplitTime { get; }
        public float SplitTimeAhead { get; }
        public float SplitTimeBehind { get; }
        public float CurrentSector1Time { get; }
        public float CurrentSector2Time { get; }
        public float CurrentSector3Time { get; }
        public float FastestSector1Time { get; }
        public float FastestSector2Time { get; }
        public float FastestSector3Time { get; }
        public float PersonalFastestLapTime { get; }
        public float PersonalFastestSector1Time { get; }
        public float PersonalFastestSector2Time { get; }
        public float PersonalFastestSector3Time { get; }

        public FlagColor HighestFlagColor { get; }
        public FlagReason HighestFlagReason { get; }

        public PitMode PitMode { get; }
        public PitSchedule PitSchedule { get; }

        public CarFlags CarFlags { get; }
        public float OilTemp { get; }
        public float OilPressure { get; }
        public float WaterTemp { get; }
        public float WaterPressure { get; }
        public float FuelPressure { get; }
        public float FuelLevel { get; }
        public float FuelCapacity { get; }
        public float Speed { get; }
        public float RPM { get; }
        public float MaxRPM { get; }
        public int Gear { get; }
        public int NumGears { get; }
        public float Odometer { get; }
        public bool AntiLockActive { get; }
        public int LastOpponentCollisionIndex { get; }
        public float LastOpponentCollisionMagnitude { get; }
        public bool BoostActive { get; }
        public float BoostAmount { get; }

        public Vector3 Orientation { get; }
        public Vector3 LocalVelocity { get; }
        public Vector3 WorldVelocity { get; }
        public Vector3 AngularVelocity { get; }
        public Vector3 LocalAcceleration { get; }
        public Vector3 WorldAcceleration { get; }
        public Vector3 ExtentsCenter { get; }

        public Tire[] Tires { get; }

        public CrashState CrashState { get; }
        public float AeroDamage { get; }
        public float EngineDamage { get; }

        public float EngineSpeed { get; }
        public float EngineTorque { get; }
        public float[] Wings { get; }
        public float HandBrake { get; }

        public int EnforcedPitStopLap { get; }
        public float BrakeBias { get; }
        public float TurboBoostPressure { get; }
    }
}
