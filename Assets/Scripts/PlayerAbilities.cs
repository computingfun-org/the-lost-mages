using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAbilities:MonoBehaviour {

    private Input inputs;
    private Ability selected;
    private void Select(Ability ability) {
        if(selected != null) {
            selected.Deselect(inputs.AbilitiesUse);
        }
        selected = ability;
        if(selected != null) {
            selected.Select(inputs.AbilitiesUse);
        }
    }

    private void Awake() {
        inputs = InputMain.GetOrCreate();
        inputs.AbilitiesSelection.One.performed += OneSelected;
        inputs.AbilitiesSelection.Two.performed += TwoSelected;
        inputs.AbilitiesSelection.Three.performed += ThreeSelected;
        inputs.AbilitiesSelection.Four.performed += FourSelected;
    }

    private void OnDestroy() {
        inputs.AbilitiesSelection.One.performed -= OneSelected;
        inputs.AbilitiesSelection.Two.performed -= TwoSelected;
        inputs.AbilitiesSelection.Three.performed -= ThreeSelected;
        inputs.AbilitiesSelection.Four.performed -= FourSelected;
        Select(null);
    }

    public Ability One;
    private void OneSelected(InputAction.CallbackContext context) =>
        Select(One);

    public Ability Two;
    private void TwoSelected(InputAction.CallbackContext context) =>
        Select(Two);

    public Ability Three;
    private void ThreeSelected(InputAction.CallbackContext context) =>
        Select(Three);

    public Ability Four;
    private void FourSelected(InputAction.CallbackContext context) =>
        Select(Four);
}
