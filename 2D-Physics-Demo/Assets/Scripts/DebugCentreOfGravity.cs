using UnityEngine;

public class DebugCentreOfGravity : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody2D;

    void FixedUpdate()
    {
        // Debug Center of gravity
        Vector3 centre = rigidbody2D.position + rigidbody2D.centerOfMass;
        Vector3 x0 = centre + Vector3.left;
        Vector3 x1 = centre + Vector3.right;
        Vector3 y0 = centre + Vector3.up;
        Vector3 y1 = centre + Vector3.down;
        Debug.DrawLine(x0, x1, Color.blue);
        Debug.DrawLine(y0, y1, Color.blue);
    }
}
