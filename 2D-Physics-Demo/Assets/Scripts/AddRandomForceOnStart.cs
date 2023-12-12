using UnityEngine;

public class AddRandomForceOnStart : MonoBehaviour
{
    [SerializeField] float minForce =  3f;
    [SerializeField] float maxForce = 10f;

    private void Start()
    {
        // Get rigidbody
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();

        // Add random force in direction
        Vector3 force = Random.onUnitSphere * Random.Range(minForce, maxForce);
        // Add all force all at once with impulse
        rigidbody2D.AddForce(force, ForceMode2D.Impulse);
    }
}
