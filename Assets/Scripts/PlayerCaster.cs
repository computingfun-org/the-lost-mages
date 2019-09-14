using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCaster:MonoBehaviour {

    private Vector2 input;

    private void Awake() {
        InputMain.GetOrCreate().Player.Look.performed += LookPerformed;
    }

    private void LookPerformed(InputAction.CallbackContext ctx) =>
        input = ctx.ReadValue<Vector2>();

    private void Update() {
        if (input == Vector2.zero) {
            return;
        }

        // TODO: cast spell
    }
}
