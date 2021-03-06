﻿// <copyright file="Enumerations.cs" company="LoadingReadyRun Community">
// Copyright (c) LoadingReadyRun Community. All rights reserved.
// </copyright>

using System;

namespace LibPCars2.SharedMemory
{
#pragma warning disable SA1602
    /// <summary>
    /// Defines the API version supported by this library.
    /// </summary>
    public enum HeaderVersion
    {
        SHARED_MEMORY_VERSION = 9,
    }

    /// <summary>
    /// Defines the maximum allowed length of a string.
    /// </summary>
    public enum StringLimits
    {
        STRING_LENGTH_MAX = 64,
    }

    /// <summary>
    /// Defines the maximum number of participants stored in the memory-mapped file.
    /// </summary>
    public enum ParticipantLimits
    {
        STORED_PARTICIPANTS_MAX = 64,
    }

    /// <summary>
    /// Defines the maximum length of a tire-compound name.
    /// </summary>
    public enum NameLimits
    {
        TIRE_COMPOUND_NAME_LENGTH_MAX = 40,
    }

    /// <summary>
    /// Lists the tires available on a vehicle.
    /// </summary>
    public enum Tires
    {
        TIRE_FRONT_LEFT = 0,
        TIRE_FRONT_RIGHT,
        TIRE_REAR_LEFT,
        TIRE_REAR_RIGHT,
        TIRE_MAX,
    }

    /// <summary>
    /// Enumerates the elements of a 3D vector.
    /// </summary>
    public enum Vector
    {
        VEC_X = 0,
        VEC_Y,
        VEC_Z,
        VEC_MAX,
    }

    /// <summary>
    /// States (modes) that the game as a whole can be in.
    /// </summary>
    public enum GameState : uint
    {
        GAME_EXITED = 0,
        GAME_FRONT_END,
        GAME_INGAME_PLAYING,
        GAME_INGAME_PAUSED,
        GAME_INGAME_INMENU_TIME_TICKING,
        GAME_INGAME_RESTARTING,
        GAME_INGAME_REPLAY,
        GAME_FRONT_END_REPLAY,
        GAME_MAX,
    }

    /// <summary>
    /// States (modes) for a single play session.
    /// </summary>
    public enum SessionState : uint
    {
        SESSION_INVALID = 0,
        SESSION_PRACTICE,
        SESSION_TEST,
        SESSION_QUALIFY,
        SESSION_FORMATION_LAP,
        SESSION_RACE,
        SESSION_TIME_ATTACK,
        SESSION_MAX,
    }

    /// <summary>
    /// States (modes) for a particular race.
    /// </summary>
    public enum RaceState : uint
    {
        RACESTATE_INVALID = 0,
        RACESTATE_NOT_STARTED,
        RACESTATE_RACING,
        RACESTATE_FINISHED,
        RACESTATE_DISQUALIFIED,
        RACESTATE_RETIRED,
        RACESTATE_DNF,
        RACESTATE_MAX,
    }

    /// <summary>
    /// Possible colors for a race signal flag.
    /// </summary>
    public enum FlagColor : uint
    {
        FLAG_COLOR_NONE = 0,
        FLAG_COLOR_GREEN,
        FLAG_COLOR_BLUE,
        FLAG_COLOR_WHITE_SLOW_CAR,
        FLAG_COLOR_WHITE_FINAL_LAP,
        FLAG_COLOR_RED,
        FLAG_COLOR_YELLOW,
        FLAG_COLOR_DOUBLE_YELLOW,
        FLAG_COLOR_BLACK_AND_WHITE,
        FLAG_COLOR_BLACK_ORANGE_CIRCLE,
        FLAG_COLOR_BLACK,
        FLAG_COLOR_CHECKERED,
        FLAG_COLOR_MAX,
    }

    /// <summary>
    /// Possible reasons for a flag to be displayed.
    /// </summary>
    public enum FlagReason : uint
    {
        FLAG_REASON_NONE = 0,
        FLAG_REASON_SOLO_CRASH,
        FLAG_REASON_VEHICLE_CRASH,
        FLAG_REASON_VEHICLE_OBSTRUCTION,
        FLAG_REASON_MAX,
    }

    /// <summary>
    /// Stages of a pit stop.
    /// </summary>
    public enum PitMode : uint
    {
        PIT_MODE_NONE = 0,
        PIT_MODE_DRIVING_INTO_PITS,
        PIT_MODE_IN_PIT,
        PIT_MODE_DRIVING_OUT_OF_PITS,
        PIT_MODE_IN_GARAGE,
        PIT_MODE_DRIVING_OUT_OF_GARAGE,
        PIT_MODE_MAX,
    }

    /// <summary>
    /// Reasons a pit stop could be scheduled.
    /// </summary>
    public enum PitSchedule : uint
    {
        PIT_SCHEDULE_NONE = 0,
        PIT_SCHEDULE_PLAYER_REQUESTED,
        PIT_SCHEDULE_ENGINEER_REQUESTED,
        PIT_SCHEDULE_DAMAGE_REQUESTED,
        PIT_SCHEDULE_MANDATORY,
        PIT_SCHEDULE_DRIVE_THROUGH,
        PIT_SCHEDULE_STOP_GO,
        PIT_SCHEDULE_PITSPOT_OCCUPIED,
        PIT_SCHEDULE_MAX,
    }

    /// <summary>
    /// Bitfield representing on/off status of various features.
    /// </summary>
    [Flags]
    public enum CarFlags : uint
    {
        CAR_HEADLIGHT = 1,
        CAR_ENGINE_ACTIVE = 2,
        CAR_ENGINE_WARNING = 4,
        CAR_SPEED_LIMITER = 8,
        CAR_ABS = 16,
        CAR_HANDBRAKE = 32,
    }

    /// <summary>
    /// Bitfield representing possible tire states.
    /// </summary>
    [Flags]
    public enum TireFlags : uint
    {
        TIRE_ATTACHED = 1,
        TIRE_INFLATED = 2,
        TIRE_IS_ON_GROUND = 4,
    }

    /// <summary>
    /// Possible terrain types a tire can be on.
    /// </summary>
    public enum TerrainType : uint
    {
        TERRAIN_ROAD = 0,
        TERRAIN_LOW_GRIP_ROAD,
        TERRAIN_BUMPY_ROAD1,
        TERRAIN_BUMPY_ROAD2,
        TERRAIN_BUMPY_ROAD3,
        TERRAIN_MARBLES,
        TERRAIN_GRASSY_BERMS,
        TERRAIN_GRASS,
        TERRAIN_GRAVEL,
        TERRAIN_BUMPY_GRAVEL,
        TERRAIN_RUMBLE_STRIPS,
        TERRAIN_DRAINS,
        TERRAIN_TIREWALLS,
        TERRAIN_CEMENTWALLS,
        TERRAIN_GUARDRAILS,
        TERRAIN_SAND,
        TERRAIN_BUMPY_SAND,
        TERRAIN_DIRT,
        TERRAIN_BUMPY_DIRT,
        TERRAIN_DIRT_ROAD,
        TERRAIN_BUMPY_DIRT_ROAD,
        TERRAIN_PAVEMENT,
        TERRAIN_DIRT_BANK,
        TERRAIN_WOOD,
        TERRAIN_DRY_VERGE,
        TERRAIN_EXIT_RUMBLE_STRIPS,
        TERRAIN_GRASSCRETE,
        TERRAIN_LONG_GRASS,
        TERRAIN_SLOPE_GRASS,
        TERRAIN_COBBLES,
        TERRAIN_SAND_ROAD,
        TERRAIN_BAKED_CLAY,
        TERRAIN_ASTROTURF,
        TERRAIN_SNOWHALF,
        TERRAIN_SNOWFULL,
        TERRAIN_DAMAGED_ROAD1,
        TERRAIN_TRAIN_TRACK_ROAD,
        TERRAIN_BUMPYCOBBLES,
        TERRAIN_ARIES_ONLY,
        TERRAIN_ORION_ONLY,
        TERRAIN_B1RUMBLES,
        TERRAIN_B2RUMBLES,
        TERRAIN_ROUGH_SAND_MEDIUM,
        TERRAIN_ROUGH_SAND_HEAVY,
        TERRAIN_SNOWWALLS,
        TERRAIN_ICE_ROAD,
        TERRAIN_RUNOFF_ROAD,
        TERRAIN_ILLEGAL_STRIP,
        TERRAIN_PAINT_CONCRETE,
        TERRAIN_PAINT_CONCRETE_ILLEGAL,
        TERRAIN_RALLY_TARMAC,
        TERRAIN_MAX,
    }

    /// <summary>
    /// Represents crash damage state.
    /// </summary>
    public enum CrashState : uint
    {
        CRASH_DAMAGE_NONE = 0,
        CRASH_DAMAGE_OFFTRACK,
        CRASH_DAMAGE_LARGE_PROP,
        CRASH_DAMAGE_SPINNING,
        CRASH_DAMAGE_ROLLING,
        CRASH_MAX,
    }
#pragma warning restore SA1602
}
