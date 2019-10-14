using System.Runtime.CompilerServices;
using Unity.Entities;
using UnityEngine.InputSystem;

public class AbilitySystem:ComponentSystem {

	const int AbilitiesLen = 4;
	readonly IAbility[] abilities = new IAbility[AbilitiesLen] {
		new NullAbility(),
		new NullAbility(),
		new NullAbility(),
		new NullAbility(),
	};

	public IAbility Ability1 {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => abilities[0];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => abilities[0] = value;
	}

	public IAbility Ability2 {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => abilities[1];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => abilities[1] = value;
	}

	public IAbility Ability3 {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => abilities[2];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => abilities[2] = value;
	}

	public IAbility Ability4 {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => abilities[3];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => abilities[3] = value;
	}

	void Performed1(InputAction.CallbackContext context) =>
		Ability1.Performed(context);

	void Performed2(InputAction.CallbackContext context) =>
		Ability2.Performed(context);

	void Performed3(InputAction.CallbackContext context) =>
		Ability3.Performed(context);

	void Performed4(InputAction.CallbackContext context) =>
		Ability4.Performed(context);

	protected override void OnUpdate() {
		for(int i = 0; i < AbilitiesLen; i++) {
			abilities[i].Update();
		}
	}

	Inputs.Actions.GameplayActions actions;

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