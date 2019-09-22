using UnityEngine;

public class FireballObj:MonoBehaviour {

    private void Start() {
        Destroy(gameObject, 5);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject);
    }
}
