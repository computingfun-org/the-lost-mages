using Unity.Entities;
using UnityEngine.InputSystem;

public interface IAbility {

	/// <summary>
	/// Called when ability is selected.
	/// </summary>
	void Select();

	/// <summary>
	/// Called when ability is deselected.
	/// </summary>
	void Deselect();

	/// <summary>
	/// Called once every frame.
	/// </summary>
	void Update();

	/// <summary>
	/// 
	/// </summary>
	void Aim(InputAction.CallbackContext context);

	/// <summary>
	/// 
	/// </summary>
	void AimPress(InputAction.CallbackContext context);

	/// <summary>
	/// 
	/// </summary>
	void Trigger(InputAction.CallbackContext context);
}

public class NullAbility:IAbility {
	public void Aim(InputAction.CallbackContext context) { }
	public void AimPress(InputAction.CallbackContext context) { }
	public void Deselect() { }
	public void Select() { }
	public void Trigger(InputAction.CallbackContext context) { }
	public void Update() { }
}

public static class AbilityExtensions {
}

public class AbilitySystem:ComponentSystem {

	IAbility ability = new NullAbility();
	public IAbility Ability {
		get => ability;
		set {
			if(Enabled) {
				ability.Deselect();
				value.Select();
			}
			ability = value;
		}
	}

	protected override void OnUpdate() => ability.Update();
	void Aim(InputAction.CallbackContext context) => ability.Aim(context);
	void AimPress(InputAction.CallbackContext context) => ability.AimPress(context);
	void Trigger(InputAction.CallbackContext context) => ability.Trigger(context);

	Inputs.Actions inputs;

	protected override void OnCreate() {
		base.OnCreate();
		inputs = new Inputs.Actions();
		inputs.AbilityUse.AimPress.performed += AimPress;
		inputs.AbilityUse.Aim.performed += Aim;
		inputs.AbilityUse.Use.performed += Trigger;
	}

	protected override void OnStartRunning() {
		base.OnStartRunning();
		inputs.Enable();
		ability.Select();
	}

	protected override void OnStopRunning() {
		base.OnStopRunning();
		inputs.Disable();
		ability.Deselect();
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		inputs.AbilityUse.Use.performed -= Trigger;
		inputs.AbilityUse.Aim.performed -= Aim;
		inputs.AbilityUse.AimPress.performed -= AimPress;
	}
}

public class AbilitySelect4System:ComponentSystem {

	readonly IAbility[] abilities = new IAbility[4] {
		new NullAbility(),
		new NullAbility(),
		new NullAbility(),
		new NullAbility(),
	};

	public IAbility Ability0 {
		get => abilities[0];
		set => abilities[0] = value;
	}
	public void Select0() => abilitySystem.Ability = Ability0;
	void Select0(InputAction.CallbackContext context) => Select0();

	public IAbility Ability1 {
		get => abilities[1];
		set => abilities[1] = value;
	}
	public void Select1() => abilitySystem.Ability = Ability1;
	void Select1(InputAction.CallbackContext context) => Select1();

	public IAbility Ability2 {
		get => abilities[2];
		set => abilities[2] = value;
	}
	public void Select2() => abilitySystem.Ability = Ability2;
	void Select2(InputAction.CallbackContext context) => Select2();

	public IAbility Ability3 {
		get => abilities[3];
		set => abilities[3] = value;
	}
	public void Select3() => abilitySystem.Ability = Ability3;
	void Select3(InputAction.CallbackContext context) => Select3();

	AbilitySystem abilitySystem;
	Inputs.Actions inputs;

	protected override void OnCreate() {
		base.OnCreate();
		abilitySystem = World.GetOrCreateSystem<AbilitySystem>();
		inputs = new Inputs.Actions();
		inputs.AbilitySelect.One.performed += Select0;
		inputs.AbilitySelect.Two.performed += Select1;
		inputs.AbilitySelect.Three.performed += Select2;
		inputs.AbilitySelect.Four.performed += Select3;
	}

	protected override void OnStartRunning() {
		base.OnStartRunning();
		inputs.Enable();
	}

	protected override void OnStopRunning() {
		base.OnStopRunning();
		inputs.Disable();
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		inputs.AbilitySelect.One.performed -= Select0;
		inputs.AbilitySelect.Two.performed -= Select1;
		inputs.AbilitySelect.Three.performed -= Select2;
		inputs.AbilitySelect.Four.performed -= Select3;
	}

	protected override void OnUpdate() { }
}