using Unity.Mathematics;
using UnityEngine;

public class CameraZoom:MonoBehaviour {

	public float Speed;
	public float MinRange;
	public float MaxRange;

	[SerializeField]
	Camera cam = null;
	Inputs.Actions inputActions;
	float input;

	void Awake() {
		inputActions = new Inputs.Actions();
		inputActions.Camera.Zoom.performed += ZoomPerformed;
	}

	void OnDestroy() {
		inputActions.Camera.Zoom.performed -= ZoomPerformed;
	}

	void OnEnable() =>
		inputActions.Enable();

	void OnDisable() =>
		inputActions.Disable();

	void ZoomPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx) =>
		input = ctx.ReadValue<float>();

	void Update() {
		float zoom = cam.orthographicSize;
		zoom -= input * Speed * Time.deltaTime;
		zoom = math.clamp(zoom, MinRange, MaxRange);
		cam.orthographicSize = zoom;
	}
}
