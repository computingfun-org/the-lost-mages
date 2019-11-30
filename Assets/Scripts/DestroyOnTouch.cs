using UnityEngine;

public class DestroyOnTouch : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D collision) {
		Destroy(gameObject);
	}
}
