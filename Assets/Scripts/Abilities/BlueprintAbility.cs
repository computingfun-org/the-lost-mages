using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class BlueprintAbility:IAbility {

	public BlueprintAbility(string prefabPath, Transform parent) {
		prefab = Resources.Load<Blueprint>(prefabPath);
		this.parent = parent;
	}

	Blueprint prefab;
	Transform parent;
	Blueprint blueprint;
	Transform blueprintTransform;

	const float moveSpeed = 25f;
	const float range = 10f;

    Vector2 delta;
    public void Aim(InputAction.CallbackContext context) {
        delta = context.ReadValue<Vector2>();
    }

    public void Deselect() {
		if (blueprint != null) {
			Object.Destroy(blueprint.gameObject);
		}
    }

    public void Select() {
        blueprint = Object.Instantiate(prefab, parent);
		blueprintTransform = blueprint.transform;
		delta = Vector2.zero;
    }

    public void Trigger(InputAction.CallbackContext context) {
        if (context.ReadValue<float>() == 1) {
            blueprint.Place();
        }
    }

    public void Update() {
        float speed = moveSpeed * Time.deltaTime;
        Vector3 pos = blueprintTransform.localPosition;
		pos.x = math.clamp(pos.x + delta.x * speed, -range, range);
		pos.y = math.clamp(pos.y + delta.y * speed, -range, range);
		blueprintTransform.localPosition = pos;
    }

	public void AimPress(InputAction.CallbackContext context) {	}
}
