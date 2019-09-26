using Unity.Entities;
using UnityEngine;

public class Scrap : MonoBehaviour {

	GOEntity player;
	EntityManager entityManager;
	AbilitySwitcherSystem abilitySwitcherSystem;

    void Start() {
		player = FindObjectOfType<PlayerEntity>();
		entityManager = World.Active.EntityManager;
		abilitySwitcherSystem = entityManager.World.GetOrCreateSystem<AbilitySwitcherSystem>();
		abilitySwitcherSystem.abilities[0] = new FireballAbility(player.entity, player.manager, new CoolDown { Value = 0.3f });
		abilitySwitcherSystem.abilities[1] = BlueprintAbilities.NewDebugCastle(player.transform);
		abilitySwitcherSystem.abilities[2] = BlueprintAbilities.NewDebugCity(player.transform);
	}
}
