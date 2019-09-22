using Unity.Entities;
using UnityEngine.InputSystem;

namespace Player {

    public interface IPlayerAbility {

        /// <summary>
        /// Called when ability is selected.
        /// </summary>
        void Select();

        /// <summary>
        /// Called when ability is deselected.
        /// </summary>
        void Deselect();

        /// <summary>
        /// Called once every frame.
        /// </summary>
        void Update();

        /// <summary>
        /// 
        /// </summary>
        void Aim(InputAction.CallbackContext context);

        /// <summary>
        /// 
        /// </summary>
        void Trigger(InputAction.CallbackContext context);
    }

    public class PlayerAbilitySystem:ComponentSystem {

        IPlayerAbility ability;
        public IPlayerAbility Ability {
            get => ability;
            set {
                if(ability != null) {
                    inputs.AbilityUse.Use.performed -= ability.Trigger;
                    inputs.AbilityUse.Aim.performed -= ability.Aim;
                    ability.Deselect();
                }
                if(value != null) {
                    ability = value;
                    ability.Select();
                    inputs.AbilityUse.Aim.performed += ability.Aim;
                    inputs.AbilityUse.Use.performed += ability.Trigger;
                }
            }
        }

        Input.Actions inputs;

        protected override void OnCreate() {
            base.OnCreate();
            inputs = new Input.Actions();
            inputs.AbilitySelect.One.performed += OneSelected;
            inputs.AbilitySelect.Two.performed += TwoSelected;
            inputs.AbilitySelect.Three.performed += ThreeSelected;
            inputs.AbilitySelect.Four.performed += FourSelected;
        }

        protected override void OnStartRunning() {
            base.OnStartRunning();
            inputs.Enable();
        }

        protected override void OnStopRunning() {
            base.OnStopRunning();
            inputs.Disable();
        }

        protected override void OnDestroy() {
            base.OnDestroy();
            inputs.AbilitySelect.One.performed -= OneSelected;
            inputs.AbilitySelect.Two.performed -= TwoSelected;
            inputs.AbilitySelect.Three.performed -= ThreeSelected;
            inputs.AbilitySelect.Four.performed -= FourSelected;
            Ability = null;
        }

        protected override void OnUpdate() => ability?.Update();

        public readonly IPlayerAbility[] Abilities = new IPlayerAbility[4];
        void OneSelected(InputAction.CallbackContext context) => Ability = Abilities[0];
        void TwoSelected(InputAction.CallbackContext context) => Ability = Abilities[1];
        void ThreeSelected(InputAction.CallbackContext context) => Ability = Abilities[2];
        void FourSelected(InputAction.CallbackContext context) => Ability = Abilities[3];
    }

}