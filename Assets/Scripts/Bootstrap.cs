using Unity.Entities;
using UnityEngine;

public class Bootstrap:MonoBehaviour {

	PlayerEntity player;
	EntityManager entityManager;
	AbilitySelect4System abilitySwitcherSystem;

	void Start() {
		player = FindObjectOfType<PlayerEntity>();
		entityManager = World.Active.EntityManager;
		abilitySwitcherSystem = entityManager.World.GetOrCreateSystem<AbilitySelect4System>();
		abilitySwitcherSystem.Ability0 = new FireballAbility(player.entity, player.manager, new CoolDown { Value = 0.3f });
	}
}
