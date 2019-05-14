// <copyright file="ParticipantInfo.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace LibPCars2.SharedMemory
{
    /// <summary>
    /// Contains data that is stored for each race participant.
    /// </summary>
    public struct ParticipantInfo
    {
        /// <summary>
        /// Indicates whether the struct contains valid data.
        /// </summary>
        public bool IsActive;

        /// <summary>
        /// The name of the participant.
        /// </summary>
        public char[] Name;

        /// <summary>
        /// Vehicle's current position.
        /// Represented as XYZ vector in world space.
        /// </summary>
        public float[] WorldPosition;

        /// <summary>
        /// Distance driven in current lap.
        /// Measured in meters. Value of 0.0f represents unset variable.
        /// </summary>
        public float CurrentLapDistance;

        /// <summary>
        /// Participant's current position on the leaderboard.
        /// Value of 0 represents unset variable.
        /// </summary>
        public uint RacePosition;

        /// <summary>
        /// Number of laps successfully completed.
        /// Value of 0 represents unset variable.
        /// </summary>
        public uint LapsCompleted;

        /// <summary>
        /// Current lap in the race.
        /// Value of 0 represents unset variable.
        /// </summary>
        public uint CurrentLap;

        /// <summary>
        /// Current sector of the race.
        /// Value of -1 represents unset variable.
        /// </summary>
        public int CurrentSector;
    }
}
