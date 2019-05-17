// <copyright file="EventInfo.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

namespace LibPCars2.SharedMemory
{
#pragma warning disable SA1516
#pragma warning disable SA1600
#pragma warning disable SA1601
    public class EventInfo
    {
        public uint LapsInEvent { get; internal set; }
        public float EventTimeRemaining { get; internal set; }
        public float TrackLength { get; internal set; }
        public int NumSectors { get; internal set; }

        public string TrackLocation { get; internal set; }
        public string TrackVariant { get; internal set; }
        public string TranslatedTrackLocation { get; internal set; }
        public string TranslatedTrackVariant { get; internal set; }

        public float WorldFastestLapTime { get; internal set; }
        public float WorldFastestSector1Time { get; internal set; }
        public float WorldFastestSector2Time { get; internal set; }
        public float WorldFastestSector3Time { get; internal set; }
    }
}
