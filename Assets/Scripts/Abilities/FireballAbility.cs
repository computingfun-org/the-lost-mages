using UnityEngine;
using UnityEngine.InputSystem;

public struct FireballAbility:IAbility {

	public PlayerEntity Player;
	public CoolDown CD;
	public bool Use;

	public void Performed(InputAction.CallbackContext context)
		=> Use = AbilityExtensions.Pressed(context);

	public void Update() {
		if(!Use) {
			return;
		}

		float time = Time.time;
		if (!CD.IsCooled(time)) {
			return;
		}

		Player.AddComponentData(new FireballSpawn { });
		CD.Trigger(time);
	}
}
