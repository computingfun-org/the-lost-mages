using Unity.Entities;

public class FireballEntity:GOEntity {

	public const float Speed = 30f;

	public Projectile Projectile {
		get => GetComponentData<Projectile>();
		set => SetComponentData(value);
	}

	public override void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
		base.Convert(entity, dstManager, conversionSystem);
		AddComponentData(new Projectile { Speed = Speed });
	}
}
