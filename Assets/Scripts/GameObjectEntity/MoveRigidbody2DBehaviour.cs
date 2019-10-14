using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

[SerializeField]
public struct MoveRigidbody2D:IComponentData {
	public float2 Position;
	public float Rotation;
}

public class MoveRigidbody2DBehaviour:MonoBehaviour {

	[SerializeField]
	GOEntity entity = null;

	[SerializeField]
	new Rigidbody2D rigidbody2D = null;

	void Start() {
		entity.AddComponentData(new MoveRigidbody2D {
			Position = rigidbody2D.position,
			Rotation = rigidbody2D.rotation,
		});
	}

	bool updated;

	void FixedUpdate() {
		MoveRigidbody2D data = entity.GetComponentData<MoveRigidbody2D>();
		rigidbody2D.MovePosition(data.Position);
		rigidbody2D.MoveRotation(data.Rotation);
		updated = true;
	}

	void Update() {
		if (updated) {
			Transform t = rigidbody2D.transform;
			entity.Translation = new Translation { Value = t.position };
			entity.Rotation = new Rotation { Value = t.rotation };
			entity.SetComponentData(new MoveRigidbody2D {
				Position = rigidbody2D.position,
				Rotation = rigidbody2D.rotation,
			});
			updated = false;
		}
	}
}
