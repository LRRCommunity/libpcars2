// <copyright file="MarshaledString.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System.Runtime.InteropServices;

namespace LibPCars2.SharedMemory.Internals
{
    /// <summary>
    /// Internal structure used for marshaling string data from binary.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    internal struct MarshaledString
    {
        /// <summary>
        /// Binary array representing a UTF8-encoded string.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)StringLimits.STRING_LENGTH_MAX)]
        public byte[] Value;
    }
}
