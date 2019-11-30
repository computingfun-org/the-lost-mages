using System.Runtime.CompilerServices;
using Unity.Entities;
using UnityEngine.InputSystem;

public interface IPlayerAbility {

	/// <summary> Called when ability is added to a system. </summary>
	void Equip();

	/// <summary> Called when ability is removed from a system. </summary>
	void Unequip();

	/// <summary> Called every frame with the value of the button it's binded to. </summary>
	void Update(float button);
}

/// <summary> A null PlayerAbility. Used be used in place of null as an empty ability. </summary>
public class NullPlayerAbility:IPlayerAbility {
	public void Equip() { }
	public void Unequip() { }
	public void Update(float button) { }
}

public class PlayerAbilitySystem:ComponentSystem {

	const int slotsLen = 4;
	readonly IPlayerAbility[] slots = new IPlayerAbility[slotsLen] {
		new NullPlayerAbility(),
		new NullPlayerAbility(),
		new NullPlayerAbility(),
		new NullPlayerAbility(),
	};

	float[] buttons = new float[slotsLen];

	Inputs.Actions.GameplayActions actions;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	void SetSlot(int i, IPlayerAbility pa) {
		slots[i].Unequip();
		slots[i] = pa;
		slots[i].Equip();
	}

	/// <summary> The player ability in slot 1. Do NOT set to null. Use NullPlayerAbility to make slot empty. </summary>
	public IPlayerAbility Ability1 {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => slots[0];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => SetSlot(0, value);
	}

	/// <summary> The player ability in slot 2. Do NOT set to null. Use NullPlayerAbility to make slot empty. </summary>
	public IPlayerAbility Ability2 {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => slots[1];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => SetSlot(1, value);
	}

	/// <summary> The player ability in slot 3. Do NOT set to null. Use NullPlayerAbility to make slot empty. </summary>
	public IPlayerAbility Ability3 {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => slots[2];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => SetSlot(2, value);
	}

	/// <summary> The player ability in slot 4. Do NOT set to null. Use NullPlayerAbility to make slot empty. </summary>
	public IPlayerAbility Ability4 {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => slots[3];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => SetSlot(0, value);
	}

	void Performed1(InputAction.CallbackContext context) =>
		buttons[0] = context.ReadValue<float>();

	void Performed2(InputAction.CallbackContext context) =>
		buttons[1] = context.ReadValue<float>();

	void Performed3(InputAction.CallbackContext context) =>
		buttons[2] = context.ReadValue<float>();

	void Performed4(InputAction.CallbackContext context) =>
		buttons[3] = context.ReadValue<float>();


	protected override void OnUpdate() {
		for(int i = 0; i < slotsLen; i++) {
			slots[i].Update(buttons[i]);
		}
	}

	protected override void OnCreate() {
		base.OnCreate();
		actions = World.GetOrCreateSystem<Inputs.InputSystem>().Actions.Gameplay;
		actions.Ability1.performed += Performed1;
		actions.Ability2.performed += Performed2;
		actions.Ability3.performed += Performed3;
		actions.Ability4.performed += Performed4;
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		actions.Ability1.performed -= Performed1;
		actions.Ability2.performed -= Performed2;
		actions.Ability3.performed -= Performed3;
		actions.Ability4.performed -= Performed4;
	}
}