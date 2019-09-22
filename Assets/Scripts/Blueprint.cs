using UnityEngine;

public class Blueprint : MonoBehaviour {

    [SerializeField]
    GameObject Object;

    [SerializeField]
    new SpriteRenderer renderer;

    Color baseColor;

    [SerializeField]
    Color overlapColor;
    private int overlaps;

    private void Awake() {
        baseColor = renderer.color;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        overlaps++;
        renderer.color = overlapColor;
    }

    private void OnTriggerExit2D(Collider2D collision) {
        overlaps--;
        if (overlaps == 0) {
            renderer.color = baseColor;
        }
    }

    public bool Place() {
        if (overlaps != 0) {
            return false;
        }
        Instantiate(Object, transform.position, Quaternion.identity);
        return true;
    }

    public bool Overlapping => overlaps > 0;
}
