using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement:MonoBehaviour {

    public const float WalkSpeed = 3f;
    public const float RunSpeed = 5f;

    private new Transform transform;
    [SerializeField]
    private Rigidbody2D body = null;

    private void Awake() {
        transform = base.transform;
        Input inputs = InputMain.GetOrCreate();
        inputs.Movement.Move.performed += MovePerformed;
        inputs.Movement.Run.performed += RunPerformed;
    }

    private void FixedUpdate() {
        Vector2 pos = transform.position;
        pos += direction * speed * Time.deltaTime;
        body.MovePosition(pos);
    }

    private float speed = WalkSpeed;
    private void RunPerformed(InputAction.CallbackContext ctx) =>
        speed = math.select(RunSpeed, WalkSpeed, ctx.ReadValue<float>() == 0f);

    private Vector2 direction;
    private void MovePerformed(InputAction.CallbackContext ctx) =>
        direction = ctx.ReadValue<Vector2>();
}
