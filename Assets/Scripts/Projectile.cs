using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;

[Serializable]
public struct Projectile:IComponentData {
	public float Speed;
}

public class ProjectileSystem:JobComponentSystem {

	struct ProjectileJob:IJobForEach<Projectile, MoveRigidbody2D> {
		public float deltaTime;
		public void Execute([ReadOnly] ref Projectile p, ref MoveRigidbody2D body) {
			float speed = deltaTime * p.Speed;
			float angle = math.radians(body.Rotation);
			body.Position.x += math.cos(angle) * speed;
			body.Position.y += math.sin(angle) * speed;
		}
	}

	protected override JobHandle OnUpdate(JobHandle inputDeps) {
		return new ProjectileJob {
			deltaTime = UnityEngine.Time.deltaTime,
		}.Schedule(this, inputDeps);
	}
}