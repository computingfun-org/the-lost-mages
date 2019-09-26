using System;
using System.Runtime.CompilerServices;
using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// Health stores the current and max health value.
/// To enfore the max health; use Set to change the value instead  of setting Value directly.
/// Decimal form is calculated with max being 1. Percent form is calculated with max being 100.
/// </summary>
[Serializable]
public struct Health:IComponentData {

	/// <summary>
	/// The current health value.
	/// To enforce max health while setting value, use Set instead.
	/// </summary>
	public float Value;

	/// <summary>
	/// The max health value.
	/// Enforced when setting the health value with Set.
	/// </summary>
	public float Max;

	/// <summary>
	/// Set the current health value clamped to max health.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Set(float value) => Value = math.min(value, Max);

	/// <summary>
	/// Is health greater than zero?
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IsAlive() => Value > 0;

	/// <summary>
	/// Is health greater than or equal to Max?
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IsMax() => Value >= Max;

	/// <summary>
	/// Health value in decimal form.
	/// Max = 1.
	/// </summary>
	public float Decimal {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => Value / Max;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => Value = value * Max;
	}

	/// <summary>
	/// Value in percentage form.
	/// Max = 100.
	/// </summary>
	public float Percent {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => Decimal * 100;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => Decimal = value / 100;
	}
}