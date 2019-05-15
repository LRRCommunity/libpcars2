// <copyright file="TelemetryData.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System.Runtime.InteropServices;

namespace LibPCars2.SharedMemory
{
#pragma warning disable SA1600
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TelemetryData
    {
        public const int SequenceOffset = 0x1C98;

        public uint Version;
        public uint BuildVersion;

        public GameState GameState;
        public SessionState SessionState;
        public RaceState RaceState;

        public int ViewedParticipantIndex;
        public int NumParticipants;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public ParticipantInfo[] ParticipantInfo;

        public float UnfilteredThrottle;
        public float UnfilteredBrake;
        public float UnfilteredSteering;
        public float UnfilteredClutch;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)StringLimits.STRING_LENGTH_MAX)]
        public byte[] CarName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)StringLimits.STRING_LENGTH_MAX)]
        public byte[] CarClassName;

        public uint LapsInEvent;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)StringLimits.STRING_LENGTH_MAX)]
        public byte[] TrackLocation;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)StringLimits.STRING_LENGTH_MAX)]
        public byte[] TrackVariation;
        public float TrackLength;

        public int NumSectors;
        [MarshalAs(UnmanagedType.I1)]
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
        [MarshalAs(UnmanagedType.I1)]
        public bool AntiLockActive;
        public int LastOpponentCollisionIndex;
        public float LastOpponentCollisionMagnitude;
        [MarshalAs(UnmanagedType.I1)]
        public bool BoostActive;
        public float BoostAmount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Vector.VEC_MAX)]
        public float[] Orientation;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Vector.VEC_MAX)]
        public float[] LocalVelocity;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Vector.VEC_MAX)]
        public float[] WorldVelocity;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Vector.VEC_MAX)]
        public float[] AngularVelocity;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Vector.VEC_MAX)]
        public float[] LocalAcceleration;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Vector.VEC_MAX)]
        public float[] WorldAcceleration;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Vector.VEC_MAX)]
        public float[] ExtentsCentre;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public TireFlags[] TireFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public TerrainType[] Terrain;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireY;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireRPS;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireSlipSpeed;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireGrip;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireHeightAboveGround;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireLateralStiffness;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireWear;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] BrakeDamage;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] SuspensionDamage;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] BrakeTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireTreadTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireLayerTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireCarcassTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] TireRimTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
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

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] WheelLocalPosition;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] SuspensionTravel;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] SuspensionVelocity;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Tires.TIRE_MAX)]
        public float[] AirPressure;
        public float EngineSpeed;
        public float EngineTorque;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] Wings;
        public float HandBrake;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public float[] CurrentSector1Times;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public float[] CurrentSector2Times;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public float[] CurrentSector3Times;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public float[] FastestSector1Times;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public float[] FastestSector2Times;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public float[] FastestSector3Times;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public float[] FastestLapTimes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public float[] LastLapTimes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX, ArraySubType = UnmanagedType.I1)]
        public bool[] LapsInvalidated;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public RaceState[] RaceStates;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public PitMode[] PitModes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX * 3)]
        public float[,] Orientations;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public float[] Speeds;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX * 64)]
        public byte[,] CarNames;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX * 64)]
        public byte[,] CarClassNames;

        public int EnforcedPitStopLap;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)StringLimits.STRING_LENGTH_MAX)]
        public byte[] TranslatedTrackLocation;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)StringLimits.STRING_LENGTH_MAX)]
        public byte[] TranslatedTrackVariation;
        public float BrakeBias;
        public float TurboBoostPressure;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)NameLimits.TYRE_COMPOUND_NAME_LENGTH_MAX * 4)]
        public byte[,] TireCompound;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public PitSchedule[] PitSchedules;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public FlagColor[] HighestFlagColors;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public FlagReason[] HighestFlagReasons;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ParticipantLimits.STORED_PARTICIPANTS_MAX)]
        public uint[] Nationalities;
        public float SnowDensity;
    }
}
