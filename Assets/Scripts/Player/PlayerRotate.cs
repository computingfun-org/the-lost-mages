using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotateSystem:ComponentSystem {

	EntityQuery query;
	InputAction action;
	Vector2 input;

	void LookPerformed(InputAction.CallbackContext context) {
		Vector2 value = context.ReadValue<Vector2>();
		if (value != Vector2.zero) {
			input = value;
		}
	}

	protected override void OnCreate() {
		base.OnCreate();
		action = World.GetOrCreateSystem<Inputs.InputSystem>().Actions.Gameplay.Look;
		action.performed += LookPerformed;
		query = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<Player>(),
			ComponentType.ReadWrite<Rigidbody2D>(),
		});
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		action.performed -= LookPerformed;
	}

	protected override void OnUpdate() {
		if(!action.enabled) {
			return;
		}

		Rigidbody2D[] bodies = query.ToComponentArray<Rigidbody2D>();
		for(int i = 0, len = bodies.Length; i < len; i++) {
			float angle = math.atan2(input.y, input.x);
			angle = math.degrees(angle);
			bodies[i].MoveRotation(angle);
		}
	}
}