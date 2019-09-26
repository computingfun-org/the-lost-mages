using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;

[Serializable]
public struct Projectile:IComponentData {
	public float Angle;
	public float Speed;
}

public class ProjectileSystem:JobComponentSystem {

	struct ProjectileJob:IJobForEach<Projectile, TranslationBody> {
		public float deltaTime;
		public void Execute([ReadOnly] ref Projectile p, ref TranslationBody t) {
			float speed = deltaTime * p.Speed;
			t.Position.x += math.sin(p.Angle) * speed;
			t.Position.y += math.cos(p.Angle) * speed;
		}
	}

	protected override JobHandle OnUpdate(JobHandle inputDeps) {
		return new ProjectileJob {
			deltaTime = UnityEngine.Time.deltaTime,
		}.Schedule(this, inputDeps);
	}
}