using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
/*
public class BuildMenuSystem:ComponentSystem {

private void BuildPerformed(InputAction.CallbackContext context) {
}

Inputs.Actions inputs;
EntityQuery itemsQuery;
EntityQuery displayQuery;

protected override void OnCreate() {
base.OnCreate();
inputs = new Inputs.Actions();
inputs.Action.Build.performed += BuildPerformed;
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
inputs.Action.Build.performed -= BuildPerformed;
}

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
*/

public class BuildMenuSelectSystem:ComponentSystem {

	InputAction moveAction;
	Selectable selectable;

	protected override void OnCreate() {
		base.OnCreate();
		moveAction = World.GetOrCreateSystem<Inputs.InputSystem>().Actions.BuildMenu.Move;
		moveAction.performed += MovePerformed;
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		moveAction.performed -= MovePerformed;
	}

	private void MovePerformed(InputAction.CallbackContext context) {
		if (selectable == null) {
			selectable = Selectable.allSelectablesArray[0];
			selectable.Select();
		}
		Vector2 value = context.ReadValue<Vector2>();
		if (math.abs(value.x) > math.abs(value.y)) {
			if (value.x > 0) {
				Selectable s = selectable.FindSelectableOnUp();
				if (s != null) {
					selectable = s;
					selectable.Select();
				}
			} else if (value.x < 0) {
				Selectable s = selectable.FindSelectableOnDown();
				if(s != null) {
					selectable = s;
					selectable.Select();
				}
			}
		} else {
			if(value.y > 0) {
				Selectable s = selectable.FindSelectableOnRight();
				if(s != null) {
					selectable = s;
					selectable.Select();
				}
			}
			else if(value.y < 0) {
				Selectable s = selectable.FindSelectableOnLeft();
				if(s != null) {
					selectable = s;
					selectable.Select();
				}
			}
		}
		Debug.Log(selectable);
	}

	protected override void OnUpdate() {
	}
}

[Serializable]
public struct BuildMenuDisplayFade:IComponentData {
	public float Duration;
}

[Serializable]
public struct BuildMenuDisplay:IComponentData { }

public class BuildMenuFadeSystem:ComponentSystem {

	EntityQuery fadeQuery;
	EntityQuery imagesQuery;
	EntityQuery inputMode;

	protected override void OnCreate() {
		base.OnCreate();
		fadeQuery = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<BuildMenuDisplayFade>(),
		});
		imagesQuery = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<BuildMenuDisplay>(),
			ComponentType.ReadWrite<RawImage>(),
		});
		inputMode = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<Inputs.InputMode>(),
		});
	}

	Inputs.Mode preMode;

	protected override void OnUpdate() {
		Inputs.Mode mode = inputMode.GetSingleton<Inputs.InputMode>().Mode;
		if (mode == preMode) {
			return;
		}
		preMode = mode;

		float alpha = math.select(0, 1, mode == Inputs.Mode.BuildMenu);
		float duration = fadeQuery.GetSingleton<BuildMenuDisplayFade>().Duration;
		RawImage[] images = imagesQuery.ToComponentArray<RawImage>();
		for(int i = 0, len = images.Length; i < len; i++) {
			images[i].CrossFadeAlpha(alpha, duration, false);
		}
	}
}