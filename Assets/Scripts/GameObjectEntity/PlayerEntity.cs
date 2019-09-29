using Unity.Entities;

public class PlayerEntity:GOEntity {

	public const float Walk = 10f;
	public const float Run = 15f;

	public Movement Movement {
		get => GetComponentData<Movement>();
		set => SetComponentData(value);
	}

	public Health Health {
		get => GetComponentData<Health>();
		set => SetComponentData(value);
	}

	public Mana Mana {
		get => GetComponentData<Mana>();
		set => SetComponentData(value);
	}

	public override void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
		base.Convert(entity, dstManager, conversionSystem);
		AddComponentData(new Player { });
		AddComponentData(new Movement { WalkSpeed = Walk, RunSpeed = Run });
		AddComponentData(new Health { });
		AddComponentData(new Mana { });
	}
}
