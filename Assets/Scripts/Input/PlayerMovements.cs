using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine.InputSystem;

public struct Movement:IComponentData {
	public float Speed;
}

public struct Dash:IComponentData {
	public float Power;
	public CoolDown CoolDown;
}

public class PlayerMovementSystem:JobComponentSystem {

	InputAction moveAction;
	float2 moveInput;

	void MovePerformed(InputAction.CallbackContext context)
		=> moveInput = context.ReadValue<UnityEngine.Vector2>();

	protected override void OnCreate() {
		base.OnCreate();
		moveAction = World.GetOrCreateSystem<Inputs.InputSystem>().Actions.Gameplay.Move;
		moveAction.performed += MovePerformed;
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		moveAction.performed -= MovePerformed;
	}

	[RequireComponentTag(typeof(Player))]
	struct PlayerMovementJob:IJobForEach<Movement, MoveRigidbody2D> {
		public float2 directionDeltaTime;
		public void Execute([ReadOnly] ref Movement m, ref MoveRigidbody2D p) {
			p.Position += m.Speed * directionDeltaTime;
		}
	}

	protected override JobHandle OnUpdate(JobHandle inputDeps) {
		return new PlayerMovementJob {
			directionDeltaTime = moveInput * UnityEngine.Time.deltaTime,
		}.Schedule(this, inputDeps);
	}
}

public class PlayerLookSystem:JobComponentSystem {

	InputAction lookAction;
	float angle;

	private void LookPerformed(InputAction.CallbackContext context) {
		UnityEngine.Vector2 value = context.ReadValue<UnityEngine.Vector2>();
		if(value != UnityEngine.Vector2.zero) {
			angle = math.atan2(value.y, value.x);
			angle = math.degrees(angle);
		}
	}

	protected override void OnCreate() {
		base.OnCreate();
		lookAction = World.GetOrCreateSystem<Inputs.InputSystem>().Actions.Gameplay.Look;
		lookAction.performed += LookPerformed;
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		lookAction.performed -= LookPerformed;
	}

	[RequireComponentTag(typeof(Player))]
	struct PlayerLookJob:IJobForEach<MoveRigidbody2D> {
		public float angle;
		public void Execute(ref MoveRigidbody2D r) {
			r.Rotation = angle;
		}
	}

	protected override JobHandle OnUpdate(JobHandle inputDeps) {
		return new PlayerLookJob {
			angle = angle,
		}.Schedule(this, inputDeps);
	}
}

public class CameraZoomSystem:ComponentSystem {

	UnityEngine.Camera camera;
	const float ZoonSpeed = 10f;
	const float ZoomMin = 30f;
	const float ZoomMax = 60f;

	InputAction zoomAction;
	float cameraInput;

	private void ZoomPerformed(InputAction.CallbackContext context) {
		cameraInput = context.ReadValue<float>();
	}

	protected override void OnCreate() {
		base.OnCreate();
		zoomAction = World.GetOrCreateSystem<Inputs.InputSystem>().Actions.Gameplay.Zoom;
		zoomAction.performed += ZoomPerformed;
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		zoomAction.performed -= ZoomPerformed;
	}

	protected override void OnUpdate() {
		if(camera == null) {
			camera = UnityEngine.Camera.main;
		}
		if(camera != null) {
			float zoom = camera.orthographicSize;
			zoom -= cameraInput * ZoonSpeed * UnityEngine.Time.deltaTime;
			zoom = math.clamp(zoom, ZoomMin, ZoomMax);
			camera.orthographicSize = zoom;
		}
	}
}
