using Unity.Mathematics;
using UnityEngine;

public static class MathCF {

    public static void LookAt2D(this Transform transform, Vector2 target) {
        Vector2 pos = transform.position;
        float x = target.x - pos.x;
        float y = target.y - pos.y;
        float a = math.atan2(y, x);
        a = math.degrees(a);
        transform.Rotate(0, 0, a);
    }
}
