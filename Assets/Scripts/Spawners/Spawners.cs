using Unity.Entities;
using UnityEngine;

public struct FireballSpawner:IComponentData { }
public class FireballSpawnerSystem:ResourceSpawnerSystem<FireballSpawner> {
	protected override Object LoadResource()
		=> Resources.Load("fireball");
}


public struct IceWallSpawner:IComponentData { }
public class IceWallSpawnSystem:ResourceSpawnerSystem<IceWallSpawner> {
	protected override Object LoadResource()
		=> Resources.Load("icewall");
}