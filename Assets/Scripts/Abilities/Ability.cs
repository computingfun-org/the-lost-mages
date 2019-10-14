using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

public interface IAbility {
	/// <summary>
	/// Performed is called with the CallbackContext of the button used to perform the ability.
	/// </summary>
	void Performed(InputAction.CallbackContext context);

	/// <summary>
	/// Is called every frame.
	/// </summary>
	void Update();
}

public struct NullAbility:IAbility {

	/// <summary> Does nothing and ignores CallbackContext. Does NOT return any exceptions or errors. </summary>
	public void Performed(InputAction.CallbackContext context) { }

	/// <summary> Does nothing. Does NOT return any exceptions or errors. </summary>
	public void Update() { }

	/// <summary> Returns true. All NullAbilitys equal all other NullAbilitys. </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Overload operator requires the unused parameter(s).")]
	public static bool operator ==(NullAbility left, NullAbility right)
		=> true;

	/// <summary> Returns false. All NullAbilitys equal all other NullAbilitys. </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Overload operator requires the unused parameter(s).")]
	public static bool operator !=(NullAbility left, NullAbility right)
		=> false;

	/// <summary> If type is NullAbility, obj equals all other NullAbilitys. </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object obj)
		=> obj is NullAbility;

	/// <summary> Not Implemented. Will always return -1. </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
		=> -1;
}

public static class AbilityExtensions {

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Value(InputAction.CallbackContext context)
		=> context.ReadValue<float>();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Pressed(InputAction.CallbackContext context)
		=> Value(context) != 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Released(InputAction.CallbackContext context)
		=> Value(context) == 0;
}