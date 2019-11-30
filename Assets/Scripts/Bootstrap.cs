using Unity.Entities;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class Bootstrap:MonoBehaviour {

	// manager
	public EntityManager entityManager;

	// systems
	public PlayerAbilitySystem abilitySystem;

	// entities & objects
	Entity inputMode;
	public Entity player;
	public CrosshairSight crosshairSight;

	void Start() {
		// manager
		entityManager = World.Active.EntityManager;

		// systems
		abilitySystem = entityManager.World.GetOrCreateSystem<PlayerAbilitySystem>();

		// entities & objects
		inputMode = entityManager.CreateEntity();
		entityManager.AddComponentData(inputMode, new Inputs.InputMode { Mode = Inputs.Mode.Gameplay });
		player = FindObjectOfType<PlayerProxy>().GetComponent<GameObjectEntity>().Entity;
		entityManager.AddComponentData(entityManager.CreateEntity(), new BuildMenuDisplayFade { Duration = .3f });

		// late setups
		abilitySystem.Ability1 = new FireballAbility(entityManager, entityManager.GetComponentObject<Transform>(player), new CoolDown { Value = 0.3f } );
		abilitySystem.Ability2 = new IceWallAbility(crosshairSight.transform, entityManager, new CoolDown { Value = 0.5f });
		abilitySystem.Ability3 = new NightSightAbility();

		Inputs.Actions actions = new Inputs.Actions();
		actions.Gameplay.Build.performed += Build_performed;
		actions.Enable();
	}

	private void Build_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj) {
		var mode = entityManager.GetComponentData<Inputs.InputMode>(inputMode);
		if (mode.Mode == Inputs.Mode.BuildMenu) {
			mode.Mode = Inputs.Mode.Gameplay;
		} else {
			mode.Mode = Inputs.Mode.BuildMenu;
		}
		entityManager.SetComponentData(inputMode, mode);
	}
}
