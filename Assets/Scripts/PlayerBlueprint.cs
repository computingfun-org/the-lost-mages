using Player;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBlueprint:IPlayerAbility {

    public Blueprint prefab;

    public float moveSpeed = 5f;

    Blueprint blueprint;

    Vector2 delta;
    public void Aim(InputAction.CallbackContext context) {
        delta = context.ReadValue<Vector2>();
    }

    public void Deselect() {
        // TODO: find out why blueprint is null before Deselect is called.
        if(blueprint != null) {
            Object.Destroy(blueprint.gameObject);
        }
    }

    public void Select() {
        blueprint = Object.Instantiate(prefab);
    }

    public void Trigger(InputAction.CallbackContext context) {
        if (context.ReadValue<float>() == 1) {
            blueprint.Place();
        }
    }

    void IPlayerAbility.Update() {
        float deltaTime = Time.deltaTime;
        Vector3 pos = blueprint.transform.position;
        pos.x += delta.x * deltaTime * moveSpeed;
        pos.y += delta.y * deltaTime * moveSpeed;
        blueprint.transform.position = pos;
    }
}
