using System;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using UnityEngine.InputSystem;

[Serializable]
public struct Dash:IComponentData {
	public float Power;
	public CoolDown CoolDown;
}

public class PlayerMovementSystem:ComponentSystem {

	EntityQuery query;
	InputAction action;
	Vector2 input;

	void MovePerformed(InputAction.CallbackContext context)
		=> input = context.ReadValue<Vector2>();

	protected override void OnCreate() {
		base.OnCreate();
		query = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<Player>(),
			ComponentType.ReadOnly<Movement>(),
			ComponentType.ReadWrite<Rigidbody2D>(),
		});
		action = World.GetOrCreateSystem<Inputs.InputSystem>().Actions.Gameplay.Move;
		action.performed += MovePerformed;
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		action.performed -= MovePerformed;
	}

	protected override void OnUpdate() {
		if (!action.enabled) {
			return;
		}

		using(NativeArray<Movement> movements = query.ToComponentDataArray<Movement>(Allocator.TempJob)) {
			Rigidbody2D[] bodies = query.ToComponentArray<Rigidbody2D>();
			Vector2 inputDeltaTime = input * Time.deltaTime;
			for(int i = 0, len = movements.Length; i < len; i++) {
				Vector2 pos = bodies[i].position;
				pos += movements[i].Speed * inputDeltaTime;
				bodies[i].MovePosition(pos);
			}
		}
	}
}



