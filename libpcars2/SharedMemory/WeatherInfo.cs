// <copyright file="WeatherInfo.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

namespace LibPCars2.SharedMemory
{
#pragma warning disable SA1516
#pragma warning disable SA1600
#pragma warning disable SA1601
    public class WeatherInfo
    {
        public float AmbientTemperature { get; internal set; }
        public float TrackTemperature { get; internal set; }

        public float RainDensity { get; internal set; }
        public float SnowDensity { get; internal set; }

        public float WindSpeed { get; internal set; }
        public float WindDirectionX { get; internal set; }
        public float WindDirectionY { get; internal set; }

        public float CloudBrightness { get; internal set; }
    }
}
