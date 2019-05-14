// <copyright file="TelemetryData.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

namespace LibPCars2.SharedMemory
{
#pragma warning disable SA1600
    public struct TelemetryData
    {
        public uint Version;
        public uint BuildVersion;

        public GameState GameState;
        public SessionState SessionState;
        public RaceState RaceState;

        public int ViewedParticipantIndex;
        public int NumParticipants;
        public ParticipantInfo[] ParticipantInfo;

        public float UnfilteredThrottle;
        public float UnfilteredBrake;
        public float UnfilteredSteering;
        public float UnfilteredClutch;

        public char[] CarName;
        public char[] CarClassName;

        public uint LapsInEvent;
        public char[] TrackLocation;
        public char[] TrackVariation;
        public float TrackLength;

        public int NumSectors;
        public bool LapInvalidated;
        public float BestLapTime;
        public float LastLapTime;
        public float CurrentTime;
        public float SplitTimeAhead;
        public float SplitTimeBehind;
        public float SplitTime;
        public float EventTimeRemaining;
        public float PersonalFastestLapTime;
        public float WorldFastestLapTime;
        public float CurrentSector1Time;
        public float CurrentSector2Time;
        public float CurrentSector3Time;
        public float FastestSector1Time;
        public float FastestSector2Time;
        public float FastestSector3Time;
        public float PersonalFastestSector1Time;
        public float PersonalFastestSector2Time;
        public float PersonalFastestSector3Time;
        public float WorldFastestSector1Time;
        public float WorldFastestSector2Time;
        public float WorldFastestSector3Time;

        public FlagColor HighestFlagColor;
        public FlagReason HighestFlagReason;

        public PitMode PitMode;
        public PitSchedule PitSchedule;

        public CarFlags CarFlags;
        public float OilTemp;
        public float OilPressure;
        public float WaterTemp;
        public float WaterPressure;
        public float FuelPressure;
        public float FuelLevel;
        public float FuelCapacity;
        public float Speed;
        public float RPM;
        public float MaxRPM;
        public float Brake;
        public float Throttle;
        public float Clutch;
        public float Steering;
        public int Gear;
        public int NumGears;
        public float Odometer;
        public bool AntiLockActive;
        public int LastOpponentCollisionIndex;
        public float LastOpponentCollisionMagnitude;
        public bool BoostActive;
        public float BoostAmount;

        public float[] Orientation;
        public float[] LocalVelocity;
        public float[] WorldVelocity;
        public float[] AngularVelocity;
        public float[] LocalAcceleration;
        public float[] WorldAcceleration;
        public float[] ExtentsCentre;

        public TireFlags[] TireFlags;
        public TerrainType[] Terrain;
        public float[] TireY;
        public float[] TireRPS;
        public float[] TireSlipSpeed;
        public float[] TireTemp;
        public float[] TireGrip;
        public float[] TireHeightAboveGround;
        public float[] TireLateralStiffness;
        public float[] TireWear;
        public float[] BrakeDamage;
        public float[] SuspensionDamage;
        public float[] BrakeTemp;
        public float[] TireTreadTemp;
        public float[] TireLayerTemp;
        public float[] TireCarcassTemp;
        public float[] TireRimTemp;
        public float[] TireInternalAirTemp;

        public CrashState CrashState;
        public float AeroDamage;
        public float EngineDamage;

        public float AmbientTemperature;
        public float TrackTemperature;
        public float RainDensity;
        public float WindSpeed;
        public float WindDirectionX;
        public float WindDirectionY;
        public float CloudBrightness;

        public uint SequenceNumber;

        public float[] WheelLocalPosition;
        public float[] SuspensionTravel;
        public float[] SuspensionVelocity;
        public float[] AirPressure;
        public float EngineSpeed;
        public float EngineTorque;
        public float[] Wings;
        public float HandBrake;

        public float[] CurrentSector1Times;
        public float[] CurrentSector2Times;
        public float[] CurrentSector3Times;
        public float[] FastestSector1Times;
        public float[] FastestSector2Times;
        public float[] FastestSector3Times;
        public float[] FastestLapTimes;
        public float[] LastLapTimes;
        public bool[] LapsInvalidated;
        public RaceState[] RaceStates;
        public PitMode[] PitModes;
        public float[][] Orientations;
        public float[] Speeds;
        public char[][] CarNames;
        public char[][] CarClassNames;

        public int EnforcedPitStopLap;
        public char[] TranslatedTrackLocation;
        public char[] TranslatedTrackVariation;
        public float BrakeBias;
        public float TurboBoostPressure;
        public char[][] TireCompound;
        public PitSchedule[] PitSchedules;
        public FlagColor[] HighestFlagColors;
        public FlagReason[] HighestFlagReasons;
        public uint[] Nationalities;
        public float SnowDensity;
    }
}
