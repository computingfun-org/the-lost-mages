using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

[Serializable]
public struct Crosshair:IComponentData {
	public float2 Position;
	public float Range;
}

public class CrosshairSystem:ComponentSystem {

	EntityQuery query;
	Vector2 input;

	private void LookPerformed(InputAction.CallbackContext context) {
		input = context.ReadValue<Vector2>();
	}

	private InputAction action;

	protected override void OnCreate() {
		base.OnCreate();
		query = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<Player>(),
			ComponentType.ReadWrite<Crosshair>(),
			ComponentType.ReadOnly<Transform>(),
		});
		action = World.GetOrCreateSystem<Inputs.InputSystem>().Actions.Gameplay.Look;
		action.performed += LookPerformed;
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		action.performed -= LookPerformed;
	}

	protected override void OnUpdate() {
		using(NativeArray<Entity> entities = query.ToEntityArray(Allocator.TempJob)) {
			for (int i = 0, len = entities.Length; i < len; i++) {
				Entity entity = entities[i];
				Crosshair crosshair = EntityManager.GetComponentData<Crosshair>(entity);
				Transform transform = EntityManager.GetComponentObject<Transform>(entity);
				float2 offset = crosshair.Range * input;
				crosshair.Position.x = transform.position.x + offset.x;
				crosshair.Position.y = transform.position.y + offset.y;
				EntityManager.SetComponentData(entity, crosshair);
			}
		}
	}
}
