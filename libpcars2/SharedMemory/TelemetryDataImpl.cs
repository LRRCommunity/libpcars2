// <copyright file="TelemetryDataImpl.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace LibPCars2.SharedMemory
{
#pragma warning disable SA1601
    public partial class TelemetryData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryData"/> class.
        /// Constructs a TelemetryData object from a binary array.
        /// </summary>
        /// <param name="data">Packed binary data retrieved from the game.</param>
        public TelemetryData(byte[] data)
        {
            if (data.Length < Marshal.SizeOf<Internals.MarshaledTelemetry>())
            {
                throw new ArgumentException("Insufficient data", "data");
            }

            Internals.MarshaledTelemetry marshaledData;
            GCHandle pinnedHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                marshaledData = Marshal.PtrToStructure<Internals.MarshaledTelemetry>(pinnedHandle.AddrOfPinnedObject());
            }
            finally
            {
                pinnedHandle.Free();
            }

            if (marshaledData.Version != (uint)HeaderVersion.SHARED_MEMORY_VERSION)
            {
                throw new ArgumentException("Incompatible API version", "data");
            }

            this.GameState = marshaledData.GameState;
            this.SessionState = marshaledData.SessionState;
            this.RaceState = marshaledData.RaceState;

            this.ViewedParticipantIndex = marshaledData.ViewedParticipantIndex;
            this.NumParticipants = marshaledData.NumParticipants;
            this.Participants = marshaledData.ParticipantInfo.Select(p => new ParticipantInfo(p)).ToArray();
            this.ParticipantsEx = Enumerable.Range(0, 64).Select(i => new ParticipantInfoEx()
            {
                CurrentSector1Time = marshaledData.CurrentSector1Times[i],
                CurrentSector2Time = marshaledData.CurrentSector2Times[i],
                CurrentSector3Time = marshaledData.CurrentSector3Times[i],
                FastestSector1Time = marshaledData.FastestSector1Times[i],
                FastestSector2Time = marshaledData.FastestSector2Times[i],
                FastestSector3Time = marshaledData.FastestSector3Times[i],
                FastestLapTime = marshaledData.FastestLapTimes[i],
                LastLapTime = marshaledData.LastLapTimes[i],
                InvalidLap = marshaledData.LapsInvalidated[i],
                RaceState = marshaledData.RaceStates[i],
                Speed = marshaledData.Speeds[i],
                PitMode = marshaledData.PitModes[i],
                PitSchedule = marshaledData.PitSchedules[i],
                HighestFlagColor = marshaledData.HighestFlagColors[i],
                HighestFlagReason = marshaledData.HighestFlagReasons[i],
                CarName = DecodeString(marshaledData.CarNames[i]),
                CarClassName = DecodeString(marshaledData.CarClassNames[i]),
                CountryCode = marshaledData.Nationalities[i],
                Orientation = new Vector3()
                {
                    X = marshaledData.Orientations[(i * 3) + 0],
                    Y = marshaledData.Orientations[(i * 3) + 1],
                    Z = marshaledData.Orientations[(i * 3) + 2],
                },
            }).ToArray();

            this.Brake = marshaledData.Brake;
            this.Clutch = marshaledData.Clutch;
            this.Steering = marshaledData.Steering;
            this.Throttle = marshaledData.Throttle;
            this.UnfilteredBrake = marshaledData.UnfilteredBrake;
            this.UnfilteredClutch = marshaledData.UnfilteredClutch;
            this.UnfilteredSteering = marshaledData.UnfilteredSteering;
            this.UnfilteredThrottle = marshaledData.UnfilteredThrottle;

            this.CarName = DecodeString(marshaledData.CarName);
            this.CarClassName = DecodeString(marshaledData.CarClassName);

            this.EventDetails = new EventInfo()
            {
                LapsInEvent = marshaledData.LapsInEvent,
                EventTimeRemaining = marshaledData.EventTimeRemaining,
                TrackLength = marshaledData.TrackLength,
                NumSectors = marshaledData.NumSectors,
                TrackLocation = DecodeString(marshaledData.TrackLocation),
                TrackVariant = DecodeString(marshaledData.TrackVariation),
                TranslatedTrackLocation = DecodeString(marshaledData.TranslatedTrackLocation),
                TranslatedTrackVariant = DecodeString(marshaledData.TranslatedTrackVariation),
                WorldFastestLapTime = marshaledData.WorldFastestLapTime,
                WorldFastestSector1Time = marshaledData.WorldFastestSector1Time,
                WorldFastestSector2Time = marshaledData.WorldFastestSector2Time,
                WorldFastestSector3Time = marshaledData.WorldFastestSector3Time,
            };
            this.Weather = new WeatherInfo()
            {
                AmbientTemperature = marshaledData.AmbientTemperature,
                TrackTemperature = marshaledData.TrackTemperature,
                RainDensity = marshaledData.RainDensity,
                SnowDensity = marshaledData.SnowDensity,
                WindSpeed = marshaledData.WindSpeed,
                WindDirectionX = marshaledData.WindDirectionX,
                WindDirectionY = marshaledData.WindDirectionY,
                CloudBrightness = marshaledData.CloudBrightness,
            };

            this.InvalidLap = marshaledData.LapInvalidated;
            this.BestLapTime = marshaledData.BestLapTime;
            this.LastLapTime = marshaledData.LastLapTime;
            this.CurrentTime = marshaledData.CurrentTime;
            this.SplitTime = marshaledData.SplitTime;
            this.SplitTimeAhead = marshaledData.SplitTimeAhead;
            this.SplitTimeBehind = marshaledData.SplitTimeBehind;
            this.CurrentSector1Time = marshaledData.CurrentSector1Time;
            this.CurrentSector2Time = marshaledData.CurrentSector2Time;
            this.CurrentSector3Time = marshaledData.CurrentSector3Time;
            this.FastestSector1Time = marshaledData.FastestSector1Time;
            this.FastestSector2Time = marshaledData.FastestSector2Time;
            this.FastestSector3Time = marshaledData.FastestSector3Time;
            this.PersonalFastestLapTime = marshaledData.PersonalFastestLapTime;
            this.PersonalFastestSector1Time = marshaledData.PersonalFastestSector1Time;
            this.PersonalFastestSector2Time = marshaledData.PersonalFastestSector2Time;
            this.PersonalFastestSector3Time = marshaledData.PersonalFastestSector3Time;

            this.HighestFlagColor = marshaledData.HighestFlagColor;
            this.HighestFlagReason = marshaledData.HighestFlagReason;

            this.PitMode = marshaledData.PitMode;
            this.PitSchedule = marshaledData.PitSchedule;

            this.CarFlags = marshaledData.CarFlags;
            this.OilTemp = marshaledData.OilTemp;
            this.OilPressure = marshaledData.OilPressure;
            this.WaterTemp = marshaledData.WaterTemp;
            this.WaterPressure = marshaledData.WaterPressure;
            this.FuelPressure = marshaledData.FuelPressure;
            this.FuelLevel = marshaledData.FuelLevel;
            this.FuelCapacity = marshaledData.FuelCapacity;
            this.Speed = marshaledData.Speed;
            this.RPM = marshaledData.RPM;
            this.MaxRPM = marshaledData.MaxRPM;
            this.Gear = marshaledData.Gear;
            this.NumGears = marshaledData.NumGears;
            this.Odometer = marshaledData.Odometer;
            this.AntiLockActive = marshaledData.AntiLockActive;
            this.LastOpponentCollisionIndex = marshaledData.LastOpponentCollisionIndex;
            this.LastOpponentCollisionMagnitude = marshaledData.LastOpponentCollisionMagnitude;
            this.BoostActive = marshaledData.BoostActive;
            this.BoostAmount = marshaledData.BoostAmount;

            this.Orientation = MakeVector(marshaledData.Orientation);
            this.LocalVelocity = MakeVector(marshaledData.LocalVelocity);
            this.WorldVelocity = MakeVector(marshaledData.WorldVelocity);
            this.AngularVelocity = MakeVector(marshaledData.AngularVelocity);
            this.LocalAcceleration = MakeVector(marshaledData.LocalAcceleration);
            this.WorldAcceleration = MakeVector(marshaledData.WorldAcceleration);
            this.ExtentsCenter = MakeVector(marshaledData.ExtentsCentre);

            this.Tires = Enumerable.Range(0, 4).Select(i => new Tire()
            {
                TireFlags = marshaledData.TireFlags[i],
                Terrain = marshaledData.Terrain[i],
                TireCompound = Internals.Utility.DecodeUtfString(marshaledData.TireCompound[i].Value),
                YPosition = marshaledData.TireY[i],
                RotationsPerSecond = marshaledData.TireRPS[i],
                Temperature = marshaledData.TireTemp[i],
                HeightAboveGround = marshaledData.TireHeightAboveGround[i],
                TireWear = marshaledData.TireWear[i],
                BrakeDamage = marshaledData.BrakeDamage[i],
                SuspensionDamage = marshaledData.SuspensionDamage[i],
                BrakeTemp = marshaledData.BrakeTemp[i],
                TreadTemp = marshaledData.TireTreadTemp[i] - Internals.Utility.KelvinOffset,
                LayerTemp = marshaledData.TireLayerTemp[i] - Internals.Utility.KelvinOffset,
                CarcassTemp = marshaledData.TireCarcassTemp[i] - Internals.Utility.KelvinOffset,
                RimTemp = marshaledData.TireRimTemp[i] - Internals.Utility.KelvinOffset,
                InternalAirTemp = marshaledData.TireInternalAirTemp[i] - Internals.Utility.KelvinOffset,
                LocalPosition = marshaledData.WheelLocalPosition[i],
                SuspensionTravel = marshaledData.SuspensionTravel[i],
                SuspensionVelocity = marshaledData.SuspensionVelocity[i],
                AirPressure = marshaledData.AirPressure[i],
#pragma warning disable CS0612
                SlipSpeed = marshaledData.TireSlipSpeed[i],
                Grip = marshaledData.TireGrip[i],
                LateralStiffness = marshaledData.TireLateralStiffness[i],
#pragma warning restore CS0612

            }).ToArray();

            this.CrashState = marshaledData.CrashState;
            this.AeroDamage = marshaledData.AeroDamage;
            this.EngineDamage = marshaledData.EngineDamage;

            this.EngineSpeed = marshaledData.EngineSpeed;
            this.EngineTorque = marshaledData.EngineTorque;
            this.Wings = marshaledData.Wings;
            this.HandBrake = marshaledData.HandBrake;

            this.EnforcedPitStopLap = marshaledData.EnforcedPitStopLap;
            this.BrakeBias = marshaledData.BrakeBias;
            this.TurboBoostPressure = marshaledData.TurboBoostPressure;

            this.SequenceNumber = marshaledData.SequenceNumber;
        }

        private static string DecodeString(Internals.MarshaledString s) => Internals.Utility.DecodeUtfString(s.Value);

        private static Vector3 MakeVector(float[] v) => Internals.Utility.DecodeVector3(v);
    }
}
