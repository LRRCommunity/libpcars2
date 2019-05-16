// <copyright file="ParticipantInfo.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System.Numerics;

namespace LibPCars2.SharedMemory
{
    /// <summary>
    /// Contains data that is stored for each race participant.
    /// </summary>
    public partial class ParticipantInfo
    {
        /// <summary>
        /// Gets a value indicating whether the object contains valid data.
        /// </summary>
        public bool IsActive { get; }

        /// <summary>
        /// Gets the name of the participant.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the vehicle's current position.
        /// Represented as XYZ vector in world space.
        /// </summary>
        public Vector3 WorldPosition { get; }

        /// <summary>
        /// Gets the distance driven in current lap.
        /// Measured in meters. Value of 0.0f represents unset variable.
        /// </summary>
        public float CurrentLapDistance { get; }

        /// <summary>
        /// Gets the participant's current position on the leaderboard.
        /// Value of 0 represents unset variable.
        /// </summary>
        public uint RacePosition { get; }

        /// <summary>
        /// Gets the number of laps successfully completed.
        /// Value of 0 represents unset variable.
        /// </summary>
        public uint LapsCompleted { get; }

        /// <summary>
        /// Gets the current lap in the race.
        /// Value of 0 represents unset variable.
        /// </summary>
        public uint CurrentLap { get; }

        /// <summary>
        /// Gets the current sector of the race.
        /// Value of -1 represents unset variable.
        /// </summary>
        public int CurrentSector { get; }
    }
}
