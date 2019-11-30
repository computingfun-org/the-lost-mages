using System;
using Unity.Entities;
using UnityEngine.InputSystem;

namespace Inputs {

	public enum Mode {
		Gameplay,
		BuildMenu,
	}

	[Serializable]
	public struct InputMode:IComponentData {
		public Mode Mode;
	}

	public class InputSystem:ComponentSystem {

		EntityQuery modeQuery;
		public Actions Actions { get; private set; }
		InputActionMap[] actionMaps;

		protected override void OnCreate() {
			base.OnCreate();
			modeQuery = GetEntityQuery(new ComponentType[] { ComponentType.ReadOnly<InputMode>() });
			Actions = new Actions();
			actionMaps = new InputActionMap[] {
				Actions.Gameplay,
				Actions.BuildMenu,
			};
		}

		protected override void OnUpdate() {
			int mode = (int)modeQuery.GetSingleton<InputMode>().Mode;
			for(int i = 0, l = actionMaps.Length; i < l; i++) {
				if(i == mode) {
					actionMaps[i].Enable();
				}
				else {
					actionMaps[i].Disable();
				}
			}
		}
	}
}


