using UnityEngine.InputSystem;

public class PlayerAbilities<A1, A2, A3, A4>
    where A1 : struct, IAbility
    where A2 : struct, IAbility
    where A3 : struct, IAbility
    where A4 : struct, IAbility {

    public System.Type OneType => typeof(A1);
    public System.Type TwoType => typeof(A2);
    public System.Type ThreeType => typeof(A3);
    public System.Type FourType => typeof(A4);

    private A1 One;
    private A2 Two;
    private A3 Three;
    private A4 Four;

    private Input inputs;

    public PlayerAbilities(A1 one, A2 two, A3 three, A4 four) {
        One = one;
        Two = two;
        Three = three;
        Four = four;
        inputs = InputMain.GetOrCreate();
        inputs.AbilitiesSelection.One.performed += OneSelected;
        inputs.AbilitiesSelection.Two.performed += TwoSelected;
        inputs.AbilitiesSelection.Three.performed += ThreeSelected;
        inputs.AbilitiesSelection.Four.performed += FourSelected;
    }

    ~PlayerAbilities() {
        inputs.AbilitiesSelection.One.performed -= OneSelected;
        inputs.AbilitiesSelection.Two.performed -= TwoSelected;
        inputs.AbilitiesSelection.Three.performed -= ThreeSelected;
        inputs.AbilitiesSelection.Four.performed -= FourSelected;
        Select(Selection.None);
    }

    public enum Selection {
        None,
        One,
        Two,
        Three,
        Four,
    }

    private Selection selected = Selection.None;

    public void Select(Selection selection) {
        Input.AbilitiesUseActions actions = inputs.AbilitiesUse;
        switch(selected) {
            case Selection.One:
                One.Deselect(actions);
                break;
            case Selection.Two:
                Two.Deselect(actions);
                break;
            case Selection.Three:
                Three.Deselect(actions);
                break;
            case Selection.Four:
                Four.Deselect(actions);
                break;
        }
        selected = selection;
        switch(selection) {
            case Selection.One:
                One.Select(actions);
                break;
            case Selection.Two:
                Two.Select(actions);
                break;
            case Selection.Three:
                Three.Select(actions);
                break;
            case Selection.Four:
                Four.Select(actions);
                break;
        }
    }

    private void OneSelected(InputAction.CallbackContext context) => Select(Selection.One);
    private void TwoSelected(InputAction.CallbackContext context) => Select(Selection.Two);
    private void ThreeSelected(InputAction.CallbackContext context) => Select(Selection.Three);
    private void FourSelected(InputAction.CallbackContext context) => Select(Selection.Four);
}
