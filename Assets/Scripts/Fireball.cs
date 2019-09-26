using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

/// <summary>
/// Tag for a place to spawn a fireball.
/// </summary>
public struct FireballSpawn:IComponentData {
    public float2 Direction;
}

public class FireballSpawnSystem:ComponentSystem {

    private UnityEngine.GameObject gObj;
    private EntityQuery query;
    private EntityCommandBufferSystem commands;

    protected override void OnCreate() {
        base.OnCreate();
        gObj = UnityEngine.Resources.Load<UnityEngine.GameObject>("fireball");
        query = GetEntityQuery(new ComponentType[] {
            ComponentType.ReadWrite<FireballSpawn>(),
            ComponentType.ReadOnly<Translation>(),
        });
        commands = World.Active.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
    }

    protected override void OnUpdate() {
        int len = query.CalculateEntityCount();
        using(NativeArray<FireballSpawn> fireballs = query.ToComponentDataArray<FireballSpawn>(Allocator.TempJob))
        using(NativeArray<Translation> translations = query.ToComponentDataArray<Translation>(Allocator.TempJob)) {
            for(int i = 0; i < len; i++) {
                UnityEngine.GameObject obj = UnityEngine.Object.Instantiate(gObj, translations[i].Value, quaternion.identity);
				FireballEntity fireballEntity = obj.GetComponent<FireballEntity>();
				Projectile projectile = fireballEntity.Projectile;
				projectile.Angle = math.atan2(fireballs[i].Direction.x, fireballs[i].Direction.y);
				fireballEntity.Projectile = projectile;
			}
        }
        commands.CreateCommandBuffer().RemoveComponent(query, ComponentType.ReadWrite<FireballSpawn>());
    }
}
