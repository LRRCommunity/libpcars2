// <copyright file="Utility.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System;
using System.Numerics;
using System.Text;

namespace LibPCars2.SharedMemory.Internals
{
#pragma warning disable SA1600
    internal static class Utility
    {
        public const int SequenceOffset = 0x1C98;

        public static string DecodeUtfString(byte[] data)
        {
            return Encoding.UTF8.GetString(data, 0, Array.IndexOf(data, (byte)'\0'));
        }

        public static Vector3 DecodeVector3(float[] data)
        {
            return new Vector3(data[0], data[1], data[2]);
        }
    }
}
