using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
    public class PlayerMovement:MonoBehaviour {

        public const float WalkSpeed = 3f;
        public const float RunSpeed = 5f;

        [SerializeField]
        private new Transform transform = null;
        [SerializeField]
        private Rigidbody2D body = null;

        private Input.Actions inputs;

        private float speed = WalkSpeed;
        private Vector2 direction;

        private void FixedUpdate() {
            Vector2 pos = transform.position;
            pos += direction * speed * Time.deltaTime;
            body.MovePosition(pos);
        }

        private void Awake() {
            inputs = new Input.Actions();
            inputs.Movement.Move.performed += MovePerformed;
            inputs.Movement.Run.performed += RunPerformed;
        }

        private void OnDestroy() {
            inputs.Movement.Move.performed -= MovePerformed;
            inputs.Movement.Run.performed -= RunPerformed;
        }

        private void OnEnable() => inputs.Enable();
        private void OnDisable() => inputs.Disable();

        private void RunPerformed(InputAction.CallbackContext ctx) =>
            speed = math.select(RunSpeed, WalkSpeed, ctx.ReadValue<float>() == 0f);

        private void MovePerformed(InputAction.CallbackContext ctx) =>
            direction = ctx.ReadValue<Vector2>();
    }
}