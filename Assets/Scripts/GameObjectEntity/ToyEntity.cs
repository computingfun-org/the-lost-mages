using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class ToyEntity:GOEntity {

	public Projectile projectile;

	void Update() {
		SetComponentData(projectile);
	}

	public override void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
		base.Convert(entity, dstManager, conversionSystem);
		AddComponentData(projectile);
	}
}
