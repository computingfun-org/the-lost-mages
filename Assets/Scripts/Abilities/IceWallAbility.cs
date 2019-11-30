using Unity.Entities;
using UnityEngine;

public class IceWallAbility:IPlayerAbility {

	readonly Transform crosshair;
	IceWallSpawnerBehaviour behaviour;
	readonly EntityManager manager;
	CoolDown cd;

	public IceWallAbility(Transform crosshair, EntityManager manager, CoolDown cd) {
		this.crosshair = crosshair;
		this.manager = manager;
		this.cd = cd;
	}

	public void Equip() {
		behaviour = Object.Instantiate(Resources.Load<IceWallSpawnerBehaviour>("icewall spawner"), crosshair);
	}

	public void Unequip() {
		Object.Destroy(behaviour.gameObject);
	}

	public void Update(float button) {
		float time = Time.time;
		if(button != 0 && cd.IsCooled(time)) {
			if(behaviour.Spawn(manager)) {
				cd.Trigger(time);
			}
		}
	}
}
