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
        /// <param name="data">Packed binary data retreived from the game.</param>
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

            this.Participants = marshaledData.ParticipantInfo.Select(p => new ParticipantInfo(p)).ToArray();
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
                AirPressure = marshaledData.AirPressure[i] / Internals.Utility.PsiFactor,
            }).ToArray();
        }

        private static string DecodeString(Internals.MarshaledString s) => Internals.Utility.DecodeUtfString(s.Value);

        private static Vector3 MakeVector(float[] v) => Internals.Utility.DecodeVector3(v);
    }
}
