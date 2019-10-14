using Unity.Entities;

namespace Inputs {

	public enum Mode {
		None,
		Gameplay,
		BuildMenu,
	}

	public struct InputMode:IComponentData {
		public Mode Mode;
	}

	public class InputSystem:ComponentSystem {

		Mode preMode;
		EntityQuery modeQuery;
		public Actions Actions { get; private set; }
		Actions.GameplayActions gameplayActions;
		Actions.BuildMenuActions buildMenuActions;

		protected override void OnCreate() {
			base.OnCreate();
			modeQuery = GetEntityQuery(new ComponentType[] { ComponentType.ReadOnly<InputMode>() });
			Actions = new Actions();
			gameplayActions = Actions.Gameplay;
			buildMenuActions = Actions.BuildMenu;
		}

		protected override void OnUpdate() {
			Mode newMode = modeQuery.GetSingleton<InputMode>().Mode;

			if (newMode == preMode) {
				return;
			}

			switch(newMode) {
				case Mode.Gameplay:
					gameplayActions.Enable();
					buildMenuActions.Disable();
					break;
				case Mode.BuildMenu:
					gameplayActions.Disable();
					buildMenuActions.Enable();
					break;
				default:
					gameplayActions.Disable();
					buildMenuActions.Disable();
					break;
			}

			preMode = newMode;
		}
	}
}


