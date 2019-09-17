using System.Runtime.CompilerServices;
using UnityEngine;

public static class CoolDownUnityTime {

    /// <summary>
    /// How long until cool down is over from Unity's Time.time.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float UntilCooled(this CoolDown cd) => cd.UntilCooled(Time.time);

    /// <summary>
    /// Is cool down over from Unity's Time.time.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsCooled(this CoolDown cd) => cd.IsCooled(Time.time);

    /// <summary>
    /// Trigger cool down at Unity's Time.time.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Trigger(this CoolDown cd) => cd.Trigger(Time.time);
}
