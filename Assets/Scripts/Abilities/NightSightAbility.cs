using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class NightSightAbility:IPlayerAbility {

	UnityEngine.Experimental.Rendering.Universal.Light2D light;

	public void Equip() {
		light = new GameObject().AddComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
		light.lightType = UnityEngine.Experimental.Rendering.Universal.Light2D.LightType.Global;
		light.color = new Color(0, 1, 0);
	}

	public void Unequip() {
		Object.Destroy(light.gameObject);
	}

	public void Update(float button) {
		light.enabled = button > 0.5;
	}
}
