using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[Serializable]
public struct Projectile:IComponentData {
	public float Speed;
}

public class ProjectileSystem:ComponentSystem {

	EntityQuery query;

	protected override void OnCreate() {
		base.OnCreate();
		query = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<Projectile>(),
			ComponentType.ReadWrite<Rigidbody2D>(),
		});
	}

	protected override void OnUpdate() {
		float deltaTime = Time.deltaTime;
		using(NativeArray<Projectile> proj = query.ToComponentDataArray<Projectile>(Allocator.TempJob)) {
			Rigidbody2D[] bodies = query.ToComponentArray<Rigidbody2D>();
			for (int i = 0, len = proj.Length; i < len; i++) {
				float speed = deltaTime * proj[i].Speed;
				float angle = math.radians(bodies[i].rotation);
				Vector2 pos = bodies[i].position;
				pos.x += math.cos(angle) * speed;
				pos.y += math.sin(angle) * speed;
				bodies[i].MovePosition(pos);
			}
		}
	}
}