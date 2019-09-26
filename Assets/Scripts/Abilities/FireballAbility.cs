using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Entities;

public class FireballAbility:IAbility {

	public FireballAbility(Entity user, EntityManager userManager, CoolDown cooldown) {
		entity = user;
		entityManager = userManager;
		cd = cooldown;
	}

	Entity entity;
    EntityManager entityManager;
	CoolDown cd;

    Vector2 aim = new Vector2 { x = 1 };
    public void Aim(InputAction.CallbackContext context) {
        Vector2 value = context.ReadValue<Vector2>();
		if (value != Vector2.zero) {
			aim = value;
		}
    }

	public void Deselect() { }
    public void Select() { }

    public void Trigger(InputAction.CallbackContext context) {
        float time = Time.time;
        if (!cd.IsCooled(time)) {
            return;
        }
        entityManager.AddComponentData(entity, new FireballSpawn { Direction = aim });
        cd.Trigger(time);
    }

    public void Update() { }

	public void AimPress(InputAction.CallbackContext context) {	}
}
