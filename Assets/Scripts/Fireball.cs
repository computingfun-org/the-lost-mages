using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Jobs;

/// <summary>
/// Tag for a place to spawn a fireball.
/// </summary>
public struct FireballSpawn:IComponentData {
    public float2 Direction;
}

public class FireballSpawnSystem:ComponentSystem {

    private FireballEntity prefab;
    private EntityQuery query;
	private EntityCommandBufferSystem commands;

    protected override void OnCreate() {
        base.OnCreate();
        prefab = UnityEngine.Resources.Load<FireballEntity>("fireball");
        query = GetEntityQuery(new ComponentType[] {
            ComponentType.ReadOnly<FireballSpawn>(),
            ComponentType.ReadOnly<Translation>(),
        });
		commands = World.Active.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
    }

	protected override void OnUpdate() {
		using(NativeArray<FireballSpawn> spawns = query.ToComponentDataArray<FireballSpawn>(Allocator.TempJob))
		using(NativeArray<Translation> translations = query.ToComponentDataArray<Translation>(Allocator.TempJob)) {
			for(int i = 0, len = spawns.Length; i < len; i++) {
				FireballEntity fe = UnityEngine.Object.Instantiate(prefab, translations[i].Value, quaternion.identity);
				Projectile p = fe.Projectile;
				p.Angle = math.atan2(spawns[i].Direction.x, spawns[i].Direction.y);
				fe.Projectile = p;
			}
		}
		commands.CreateCommandBuffer().RemoveComponent(query, typeof(FireballSpawn));
	}
}
