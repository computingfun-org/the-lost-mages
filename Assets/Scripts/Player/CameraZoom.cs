using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

[Serializable]
public struct CameraZoom:IComponentData {
	public float Speed;
	public float Min;
	public float Max;
}

public class CameraZoomSystem:ComponentSystem {

	EntityQuery query;
	InputAction action;
	float input;

	void ZoomPerformed(InputAction.CallbackContext context)
		=> input = context.ReadValue<float>();

	protected override void OnCreate() {
		base.OnCreate();
		query = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadWrite<Camera>(),
			ComponentType.ReadOnly<CameraZoom>(),
		});
		action = World.GetOrCreateSystem<Inputs.InputSystem>().Actions.Gameplay.Zoom;
		action.performed += ZoomPerformed;
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		action.performed -= ZoomPerformed;
	}

	protected override void OnUpdate() {
		if(!action.enabled) {
			return;
		}

		using(NativeArray<CameraZoom> zooms = query.ToComponentDataArray<CameraZoom>(Allocator.TempJob)) {
			Camera[] cameras = query.ToComponentArray<Camera>();
			float inputDeltaTime = input * Time.deltaTime;
			for(int i = 0, len = zooms.Length; i < len; i++) {
				float oSize = cameras[i].orthographicSize;
				oSize -= zooms[i].Speed * inputDeltaTime;
				oSize = math.clamp(oSize, zooms[i].Min, zooms[i].Max);
				cameras[i].orthographicSize = oSize;
			}
		}
	}
}
