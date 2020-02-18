using System.Runtime.CompilerServices;
using Unity.Mathematics;

public static class HealthExtension {

	/// <summary> Set the current health value clamped to max health. </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Set(this Health h, float v) => h.Value = math.min(v, h.Max);

	/// <summary> Is health greater than zero? </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsAlive(this Health h) => h.Value > 0;

	/// <summary> Is health greater than or equal to Max? </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsMax(this Health h) => h.Value >= h.Max;

	/// <summary> Health value in decimal form. </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Decimal(this Health h)  => h.Value / h.Max;

	/// <summary> Health value in decimal form. </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SetDecimal(this Health h, float d) => h.Value = d * h.Max;

	/// <summary> Value in percentage form. </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Percent(this Health h) => h.Decimal() * 100;

	/// <summary> Value in percentage form. </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SetPercent(this Health h, float p) => h.SetDecimal(p / 100);
}