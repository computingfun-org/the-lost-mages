using UnityEngine;

public class ShootObject : MonoBehaviour {

    [SerializeField]
    public float Speed;

    private void Update() {
        // TODO: better way to move object forward?
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        // TODO: remove magic number 8 (player layer number) and find better way to avoid player.
        if (collision.gameObject.layer != 8) {
            Destroy(gameObject);
        }
    }
}
