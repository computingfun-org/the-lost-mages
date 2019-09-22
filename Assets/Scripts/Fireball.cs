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

    private UnityEngine.GameObject fireballObj;
    private EntityQuery query;
    private EntityCommandBufferSystem commands;

    protected override void OnCreate() {
        base.OnCreate();
        fireballObj = UnityEngine.Resources.Load<UnityEngine.GameObject>("fireball");
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
                UnityEngine.GameObject obj = UnityEngine.Object.Instantiate(fireballObj, translations[i].Value + new float3 { x = fireballs[i].Direction.x * 1.5f, y = fireballs[i].Direction.y * 1.5f }, quaternion.identity);
                obj.GetComponent<UnityEngine.Rigidbody2D>().velocity = fireballs[i].Direction * 5;
            }
        }
        commands.CreateCommandBuffer().RemoveComponent(query, ComponentType.ReadWrite<FireballSpawn>());
    }
}
