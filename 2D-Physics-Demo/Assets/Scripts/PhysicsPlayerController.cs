using UnityEngine;

public class PhysicsPlayerController : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody2D;
    [SerializeField] float forceHorizontal = 3f;
    [SerializeField] float forceOnCollision = 3f;

    void FixedUpdate()
    {
        // Add force horizontally
        rigidbody2D.AddForce(Vector2.right * forceHorizontal);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // Add force at each contact point
        foreach (ContactPoint2D contact in collision.contacts)
        {
            // Use impulse to add force instantaneously
            rigidbody2D.AddForce(contact.normal * forceOnCollision, ForceMode2D.Impulse);
        }
    }

}
