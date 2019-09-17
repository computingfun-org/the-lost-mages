﻿using System.Runtime.CompilerServices;

public struct CoolDown {

    /// <summary>
    /// Time of cool down.
    /// </summary>
    public float Value;

    /// <summary>
    /// Time cool down was last triggered.
    /// </summary>
    public float Triggered;

    /// <summary>
    /// Time when cool down is over.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float WhenCooled() => Triggered + Value;

    /// <summary>
    /// How long until cool down is over.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float UntilCooled(float time) {
        float until = WhenCooled() - time;
        return until > 0 ? until : 0;
    }

    /// <summary>
    /// Is cool down over.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsCooled(float time) => time >= WhenCooled();

    /// <summary>
    /// Trigger cool down at time.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Trigger(float time) => Triggered = time;
}
