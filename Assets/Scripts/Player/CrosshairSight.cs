using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class CrosshairSight:MonoBehaviour {

	[SerializeField]
	GameObjectEntity entity = null;

	void Update() {
		float2 crosshair = entity.EntityManager.GetComponentData<Crosshair>(entity.Entity).Position;
		transform.position = new Vector3(crosshair.x, crosshair.y);
	}
}
