using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public struct TranslationBody:IComponentData {
	public float2 Position;
}

public class TranslationBodyBehaviour:MonoBehaviour {

	[SerializeField]
	GOEntity entity = null;

	[SerializeField]
	Rigidbody2D body = null;

	bool updated;

	void Start() {
		entity.AddComponentData(new TranslationBody { Position = body.position });
	}

	void FixedUpdate() {
		body.MovePosition(entity.GetComponentData<TranslationBody>().Position);
		updated = true;
	}

	void Update() {
		if (updated) {
			Vector2 pos = body.position;
			entity.SetComponentData(new TranslationBody { Position = pos });
			entity.SetComponentData(new Translation { Value = new float3 { x = pos.x, y = pos.y } });
			updated = false;
		}
	}
}
