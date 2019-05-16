// <copyright file="MarshaledTireCompoundName.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System.Runtime.InteropServices;

namespace LibPCars2.SharedMemory.Internals
{
    /// <summary>
    /// Internal structure for marshaling names of tire compounds.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    internal struct MarshaledTireCompoundName
    {
        /// <summary>
        /// Binary array representing a UTF8-encoded string.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)NameLimits.TIRE_COMPOUND_NAME_LENGTH_MAX)]
        public byte[] Value;
    }
}
