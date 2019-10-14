using Unity.Entities;

public class PlayerEntity:GOEntity {

	public Movement Movement {
		get => GetComponentData<Movement>();
		set => SetComponentData(value);
	}

	public Dash Dash {
		get => GetComponentData<Dash>();
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
		AddComponentData(new Movement { Speed = 10f });
		AddComponentData(new Dash {
			CoolDown = new CoolDown {
				Triggered = float.NegativeInfinity,
				Value = 1f,
			},
			Power = 15f
		});
		AddComponentData(new Health { });
		AddComponentData(new Mana { });
	}
}
