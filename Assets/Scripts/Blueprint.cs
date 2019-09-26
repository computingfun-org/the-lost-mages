using UnityEngine;

public class Blueprint : MonoBehaviour {

    [SerializeField]
    GameObject prefab = null;

    [SerializeField]
    SpriteRenderer sprite = null;

    Color baseColor;

    [SerializeField]
    Color overlapColor = Color.red;

    private int overlaps;

    private void Awake() {
        baseColor = sprite.color;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        overlaps++;
        sprite.color = overlapColor;
    }

    private void OnTriggerExit2D(Collider2D collision) {
        overlaps--;
        if (overlaps == 0) {
            sprite.color = baseColor;
        }
    }

    public bool Place() {
        if (Overlapping) {
            return false;
        }
        Instantiate(prefab, transform.position, Quaternion.identity);
        return true;
    }

    public bool Overlapping => overlaps > 0;
}
