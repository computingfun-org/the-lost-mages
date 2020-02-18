using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class TorchAbility:IPlayerAbility {

	readonly EntityManager manager;
	readonly Transform source;
	CoolDown cd;

	public TorchAbility(EntityManager manager, Transform source, CoolDown cd) {
		this.manager = manager;
		this.source = source;
		this.cd = cd;
	}

	public void Equip() { }

	public void Unequip() { }

	public void Update(float button) {
		float time = Time.time;
		if(button != 0 && cd.IsCooled(time)) {
			Entity e = manager.CreateEntity();
			manager.AddComponentData(e, new TorchSpawner { });
			manager.AddComponentData(e, new LocalToWorld { Value = source.localToWorldMatrix });
			manager.AddComponentData(e, new DestoryResourceSpawner { });
			cd.Trigger(time);
		}
	}
}
