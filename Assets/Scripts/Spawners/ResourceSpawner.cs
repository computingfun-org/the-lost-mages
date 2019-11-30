using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

/// <summary>
/// Add tag with any ResourceSpawner tag to have the entity destroyed after resource spawns.
/// Without DestoryResourceSpawner tag, only the ResourceSpawner tag is removed after resource spawns.
/// </summary>
public struct DestoryResourceSpawner:IComponentData { }

public static class ResourceSpawner<T> where T : struct, IComponentData {

	public static Entity CreateSpawner(EntityManager manager, LocalToWorld ltw, bool destory) {
		Entity entity = manager.CreateEntity(new ComponentType[] { typeof(T) });
		manager.AddComponentData(entity, ltw);
		if(destory) {
			manager.AddComponentData(entity, new DestoryResourceSpawner { });
		}
		return entity;
	}

	public static Entity CreateSpawner(EntityManager manager, Transform t, bool destory) {
		return CreateSpawner(manager, new LocalToWorld { Value = t.localToWorldMatrix }, destory);
	}
}

public abstract class ResourceSpawnerBehaviour<T>:MonoBehaviour where T : struct, IComponentData {

	public virtual bool CanSpawn => true;
	public virtual bool DestroyEntity => true;

	public bool Spawn(EntityManager manager) {
		if (!CanSpawn) {
			return false;
		}
		ResourceSpawner<T>.CreateSpawner(manager, transform, DestroyEntity);
		return true;
	}
}

public abstract class ResourceSpawnerSystem<T>:ComponentSystem where T : struct, IComponentData {

	private Object resource;
	private EntityQuery querySpawn;
	private EntityQuery queryRemove;
	private EntityQuery queryDestory;
	private EntityCommandBufferSystem commandSystem;

	protected abstract Object LoadResource();

	protected override void OnCreate() {
		base.OnCreate();
		resource = LoadResource();
		querySpawn = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<T>(),
			ComponentType.ReadOnly<LocalToWorld>(),
		});
		queryRemove = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<T>(),
			ComponentType.Exclude<DestoryResourceSpawner>(),
		});
		queryDestory = GetEntityQuery(new ComponentType[] {
			ComponentType.ReadOnly<T>(),
			ComponentType.ReadOnly<DestoryResourceSpawner>(),
		});
		commandSystem = World.Active.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
	}

	protected override void OnUpdate() {
		using(NativeArray<LocalToWorld> localToWorlds = querySpawn.ToComponentDataArray<LocalToWorld>(Allocator.TempJob)) {
			for(int i = 0, len = localToWorlds.Length; i < len; i++) {
				Object.Instantiate(resource, localToWorlds[i].Position, math.quaternion(localToWorlds[i].Value));
			}
		}
		EntityCommandBuffer commandBuffer = commandSystem.CreateCommandBuffer();
		commandBuffer.RemoveComponent(queryRemove, typeof(T));
		commandBuffer.DestroyEntity(queryDestory);
	}
}
