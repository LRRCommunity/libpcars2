// <copyright file="ParticipantInfoImpl.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

namespace LibPCars2.SharedMemory
{
    /// <summary>
    /// Contains data that is stored for each race participant.
    /// </summary>
    public partial class ParticipantInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantInfo"/> class.
        /// </summary>
        /// <param name="pData">Marshaled binary data.</param>
        internal ParticipantInfo(Internals.MarshaledParticipant pData)
        {
            this.IsActive = pData.IsActive;
            this.Name = Internals.Utility.DecodeUtfString(pData.Name.Value);
            this.WorldPosition = Internals.Utility.DecodeVector3(pData.WorldPosition);
            this.CurrentLapDistance = pData.CurrentLapDistance;
            this.RacePosition = pData.RacePosition;
            this.LapsCompleted = pData.LapsCompleted;
            this.CurrentLap = pData.CurrentLap;
            this.CurrentSector = pData.CurrentSector;
        }
    }
}
