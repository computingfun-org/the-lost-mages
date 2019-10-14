using Unity.Entities;
using UnityEngine;

public class Bootstrap:MonoBehaviour {

	public PlayerEntity player;
	public EntityManager entityManager;
	public AbilitySystem abilitySystem;

	void AddInputMode(EntityManager em) {
		Entity e = em.CreateEntity();
		Inputs.InputMode im = new Inputs.InputMode {
			Mode = Inputs.Mode.Gameplay,
		};
		em.AddComponentData(e, im);
	}

	void Start() {
		player = FindObjectOfType<PlayerEntity>();
		entityManager = World.Active.EntityManager;
		AddInputMode(entityManager);
		abilitySystem = entityManager.World.GetOrCreateSystem<AbilitySystem>();
		abilitySystem.Ability1 = new FireballAbility {
			Player = player,
			CD = new CoolDown { Value = 0.3f },
		};
	}
}
