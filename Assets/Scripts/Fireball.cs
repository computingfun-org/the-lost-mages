using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Jobs;

/// <summary>
/// Tag for a place to spawn a fireball.
/// </summary>
public struct FireballSpawn:IComponentData { }

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
			ComponentType.ReadOnly<Rotation>(),
        });
		commands = World.Active.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
    }

	protected override void OnUpdate() {
		using(NativeArray<Translation> translations = query.ToComponentDataArray<Translation>(Allocator.TempJob))
		using(NativeArray<Rotation> rotations = query.ToComponentDataArray<Rotation>(Allocator.TempJob)) {
			for(int i = 0, len = translations.Length; i < len; i++) {
				UnityEngine.Object.Instantiate(prefab, translations[i].Value, rotations[i].Value);
			}
		}
		commands.CreateCommandBuffer().RemoveComponent(query, typeof(FireballSpawn));
	}
}
