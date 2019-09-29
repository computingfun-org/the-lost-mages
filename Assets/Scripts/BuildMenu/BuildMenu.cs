using Unity.Entities;
using UnityEngine;
using UnityEngine.InputSystem;

public class BuildMenuSystem:ComponentSystem, IAbility {

	Input.Actions inputs;
	AbilitySystem abilitySystem;
	EntityQuery itemsQuery;
	EntityQuery displayQuery;

	protected override void OnCreate() {
		base.OnCreate();
		inputs = new Input.Actions();
		inputs.Build.Menu.performed += Performed;
		abilitySystem = World.GetOrCreateSystem<AbilitySystem>();
		itemsQuery = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<BuildMenuItem>(),
		});
		displayQuery = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<BuildMenuDisplay>(),
		});
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
		inputs.Build.Menu.performed -= Performed;
	}

	protected override void OnUpdate() { }

	void Performed(InputAction.CallbackContext context) =>
		abilitySystem.Ability = abilitySystem.Ability is BuildMenuSystem ? new NullAbility { } : (IAbility)this;

	#region IAbility

	const float deadZone = 0.5f;
	int selected;
	CoolDown cd = new CoolDown { Value = 0.3f };
	Vector2 aim;
	BuildMenuItem[] items;

	void IAbility.Deselect() {
		BuildMenuDisplay.DisplayAll(displayQuery, false);
	}

	void IAbility.Select() {
		items = itemsQuery.ToComponentArray<BuildMenuItem>();
		if (selected < 0 || selected > items.Length) {
			selected = 0;
		}
		BuildMenuDisplay.DisplayAll(displayQuery, true);
	}
	
	void IAbility.Aim(InputAction.CallbackContext context) {
		aim = context.ReadValue<Vector2>();
	}

	void IAbility.AimPress(InputAction.CallbackContext context) { }
	
	void IAbility.Update() {
		float time = Time.time;
		if(cd.IsCooled(time)) {
			if(aim.x > deadZone) {
				selected = (selected + 1) % items.Length;
				cd.Trigger(time);
			}
			else if(aim.x < -deadZone) {
				selected = selected < 1 ? items.Length - 1 : selected - 1;
				cd.Trigger(time);
			}
		}

		for(int i = 0, len = items.Length; i < len; i++) {
			items[i].Selected = i == selected;
		}
	}

	void IAbility.Trigger(InputAction.CallbackContext context) {
		if(context.ReadValue<float>() == 1) {
			abilitySystem.Ability = items[selected].Ability;
		}
	}

	#endregion
}
