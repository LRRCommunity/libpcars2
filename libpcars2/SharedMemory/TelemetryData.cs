// <copyright file="TelemetryData.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

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

        public int ViewedParticipantIndex { get; }
        public int NumParticipants { get; }
        public ParticipantInfo[] ParticipantInfo { get; }

        public float UnfilteredThrottle { get; }
        public float UnfilteredBrake { get; }
        public float UnfilteredSteering { get; }
        public float UnfilteredClutch { get; }

        public string CarName { get; }
        public string CarClassName { get; }

        public uint LapsInEvent { get; }
        public string TrackLocation { get; }
        public string TrackVariation { get; }
        public float TrackLength { get; }

        public int NumSectors { get; }
        public bool LapInvalidated { get; }
        public float BestLapTime { get; }
        public float LastLapTime { get; }
        public float CurrentTime { get; }
        public float SplitTimeAhead { get; }
        public float SplitTimeBehind { get; }
        public float SplitTime { get; }
        public float EventTimeRemaining { get; }
        public float PersonalFastestLapTime { get; }
        public float WorldFastestLapTime { get; }
        public float CurrentSector1Time { get; }
        public float CurrentSector2Time { get; }
        public float CurrentSector3Time { get; }
        public float FastestSector1Time { get; }
        public float FastestSector2Time { get; }
        public float FastestSector3Time { get; }
        public float PersonalFastestSector1Time { get; }
        public float PersonalFastestSector2Time { get; }
        public float PersonalFastestSector3Time { get; }
        public float WorldFastestSector1Time { get; }
        public float WorldFastestSector2Time { get; }
        public float WorldFastestSector3Time { get; }

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
        public float Brake { get; }
        public float Throttle { get; }
        public float Clutch { get; }
        public float Steering { get; }
        public int Gear { get; }
        public int NumGears { get; }
        public float Odometer { get; }
        public bool AntiLockActive { get; }
        public int LastOpponentCollisionIndex { get; }
        public float LastOpponentCollisionMagnitude { get; }
        public bool BoostActive { get; }
        public float BoostAmount { get; }

        public float[] Orientation { get; }
        public float[] LocalVelocity { get; }
        public float[] WorldVelocity { get; }
        public float[] AngularVelocity { get; }
        public float[] LocalAcceleration { get; }
        public float[] WorldAcceleration { get; }
        public float[] ExtentsCentre { get; }

        public TireFlags[] TireFlags { get; }
        public TerrainType[] Terrain { get; }
        public float[] TireY { get; }
        public float[] TireRPS { get; }
        public float[] TireSlipSpeed { get; }
        public float[] TireTemp { get; }
        public float[] TireGrip { get; }
        public float[] TireHeightAboveGround { get; }
        public float[] TireLateralStiffness { get; }
        public float[] TireWear { get; }
        public float[] BrakeDamage { get; }
        public float[] SuspensionDamage { get; }
        public float[] BrakeTemp { get; }
        public float[] TireTreadTemp { get; }
        public float[] TireLayerTemp { get; }
        public float[] TireCarcassTemp { get; }
        public float[] TireRimTemp { get; }
        public float[] TireInternalAirTemp { get; }

        public CrashState CrashState { get; }
        public float AeroDamage { get; }
        public float EngineDamage { get; }

        public float AmbientTemperature { get; }
        public float TrackTemperature { get; }
        public float RainDensity { get; }
        public float WindSpeed { get; }
        public float WindDirectionX { get; }
        public float WindDirectionY { get; }
        public float CloudBrightness { get; }

        public uint SequenceNumber { get; }

        public float[] WheelLocalPosition { get; }
        public float[] SuspensionTravel { get; }
        public float[] SuspensionVelocity { get; }
        public float[] AirPressure { get; }
        public float EngineSpeed { get; }
        public float EngineTorque { get; }
        public float[] Wings { get; }
        public float HandBrake { get; }

        public float[] CurrentSector1Times { get; }
        public float[] CurrentSector2Times { get; }
        public float[] CurrentSector3Times { get; }
        public float[] FastestSector1Times { get; }
        public float[] FastestSector2Times { get; }
        public float[] FastestSector3Times { get; }
        public float[] FastestLapTimes { get; }
        public float[] LastLapTimes { get; }
        public bool[] LapsInvalidated { get; }
        public RaceState[] RaceStates { get; }
        public PitMode[] PitModes { get; }
        public float[,] Orientations { get; }
        public float[] Speeds { get; }
        public string[] CarNames { get; }
        public string[] CarClassNames { get; }

        public int EnforcedPitStopLap { get; }
        public string TranslatedTrackLocation { get; }
        public string TranslatedTrackVariation { get; }
        public float BrakeBias { get; }
        public float TurboBoostPressure { get; }
        public string[] TireCompound { get; }
        public PitSchedule[] PitSchedules { get; }
        public FlagColor[] HighestFlagColors { get; }
        public FlagReason[] HighestFlagReasons { get; }
        public uint[] Nationalities { get; }
        public float SnowDensity { get; }
    }
}
