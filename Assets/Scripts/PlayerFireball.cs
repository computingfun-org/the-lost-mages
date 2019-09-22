using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Entities;

public class PlayerFireball:Player.IPlayerAbility {

    public Entity playerEntity;
    public EntityManager entityManager;

    CoolDown cd = new CoolDown {
        Value = .5f,
        Triggered = float.MinValue,
    };

    Vector2 aim;

    public void Aim(InputAction.CallbackContext context) {
        aim = context.ReadValue<Vector2>();
    }

    public void Deselect() {
        
    }

    public void Select() {
        
    }

    public void Trigger(InputAction.CallbackContext context) {
        float time = Time.time;
        if (!cd.IsCooled(time)) {
            return;
        }
        entityManager.AddComponentData(playerEntity, new FireballSpawn { Direction = aim });
        cd.Trigger(time);
    }

    public void Update() {

    }
}
