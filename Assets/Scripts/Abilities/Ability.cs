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

public class AbilitySystem:ComponentSystem {

	IAbility ability;
	public IAbility Ability {
		get => ability;
		set {
			if(ability != null) {
				inputs.AbilityUse.Use.performed -= ability.Trigger;
				inputs.AbilityUse.Aim.performed -= ability.Aim;
				inputs.AbilityUse.AimPress.performed -= ability.AimPress;
				ability.Deselect();
			}
			if(value != null) {
				ability = value;
				ability.Select();
				inputs.AbilityUse.AimPress.performed += ability.AimPress;
				inputs.AbilityUse.Aim.performed += ability.Aim;
				inputs.AbilityUse.Use.performed += ability.Trigger;
			}
		}
	}

	Input.Actions inputs;

	protected override void OnCreate() {
		base.OnCreate();
		inputs = new Input.Actions();
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
		Ability = null;
	}

	protected override void OnUpdate() => ability?.Update();	
}

public class AbilitySwitcherSystem:ComponentSystem {

	public readonly IAbility[] abilities = new IAbility[4];

	public void Selected0() => abilitySystem.Ability = abilities[0];
	public void Selected1() => abilitySystem.Ability = abilities[1];
	public void Selected2() => abilitySystem.Ability = abilities[2];
	public void Selected3() => abilitySystem.Ability = abilities[3];

	void Selected0(InputAction.CallbackContext context) => Selected0();
	void Selected1(InputAction.CallbackContext context) => Selected1();
	void Selected2(InputAction.CallbackContext context) => Selected2();
	void Selected3(InputAction.CallbackContext context) => Selected3();

	AbilitySystem abilitySystem;
	Input.Actions inputs;

	protected override void OnCreate() {
		base.OnCreate();
		abilitySystem = World.GetOrCreateSystem<AbilitySystem>();
		inputs = new Input.Actions();
		inputs.AbilitySelect.One.performed += Selected0;
		inputs.AbilitySelect.Two.performed += Selected1;
		inputs.AbilitySelect.Three.performed += Selected2;
		inputs.AbilitySelect.Four.performed += Selected3;
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
		inputs.AbilitySelect.One.performed -= Selected0;
		inputs.AbilitySelect.Two.performed -= Selected1;
		inputs.AbilitySelect.Three.performed -= Selected2;
		inputs.AbilitySelect.Four.performed -= Selected3;
	}

	protected override void OnUpdate() { }
}