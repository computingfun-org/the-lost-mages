using UnityEngine;

public class IceWallSpawnerBehaviour:ResourceSpawnerBehaviour<IceWallSpawner> {

	[SerializeField]
	Triggers2D triggers;

	public override bool CanSpawn
		=> triggers.IsTriggered ? false : base.CanSpawn;
}