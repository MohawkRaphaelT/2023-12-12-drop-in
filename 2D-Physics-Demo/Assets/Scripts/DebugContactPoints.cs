using UnityEngine;

public class DebugContactPoints : MonoBehaviour
{
    [SerializeField] float debugLength = 2.5f;

    private void OnCollisionStay2D(Collision2D collision)
    {
        foreach (ContactPoint2D contact in collision.contacts)
        {
            Vector3 start = contact.point;
            Vector3 end = contact.point + contact.normal * debugLength;
            Debug.DrawLine(start, end, Color.black);
        }
    }
}
