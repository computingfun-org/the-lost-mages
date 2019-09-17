using UnityEngine;
using UnityEngine.InputSystem;

public struct ShootAbility:IAbility {

    /// <summary>
    /// Where projectile is shoot from.
    /// </summary>
    public Transform source;

    /// <summary>
    /// Prefab to be instantiated.
    /// </summary>
    public GameObject projectile;

    /// <summary>
    /// Cool down until next shot can be fired.
    /// </summary>
    public CoolDown cd;

    private void Use(InputAction.CallbackContext context) {
        if(!cd.IsCooled(Time.time)) {
            return;
        }
        if(context.ReadValue<float>() != 1) {
            return;
        }
        Vector3 pos = source.position;
        GameObject spawn = Object.Instantiate(projectile, pos, Quaternion.identity);
        spawn.transform.LookAt2D((Vector2)pos + aim);
        cd.Trigger(Time.time);
    }

    private Vector2 aim;
    private void Aim(InputAction.CallbackContext context) {
        aim = context.ReadValue<Vector2>();
    }

    public void Select(Input.AbilitiesUseActions actions) {
        actions.Aim.performed += Aim;
        actions.Use.performed += Use;
    }

    public void Deselect(Input.AbilitiesUseActions actions) {
        actions.Use.performed -= Use;
        actions.Aim.performed -= Aim;
    }
}
