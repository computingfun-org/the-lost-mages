using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootAbility:Ability {

    public GameObject obj;
    private Vector2 aim;

    public override void Deselect(Input.AbilitiesUseActions actions) {
        actions.Use.performed -= Use;
        actions.Aim.performed -= Aim;
    }

    public override void Select(Input.AbilitiesUseActions actions) {
        actions.Aim.performed += Aim;
        actions.Use.performed += Use;
    }

    private void Use(InputAction.CallbackContext context) {
        if(!IsCooled(Time.time)) {
            return;
        }
        if (context.ReadValue<float>() != 1) {
            return;
        }
        Vector3 pos = transform.position;
        GameObject spawn = Instantiate(obj, pos, Quaternion.identity);
        spawn.transform.LookAt2D((Vector2)pos + aim);
        LastUsed = Time.time;
    }

    private void Aim(InputAction.CallbackContext context) {
        aim = context.ReadValue<Vector2>();
    }
}
