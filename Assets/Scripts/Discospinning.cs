using UnityEngine;

public class DiscoPhysicsSpinner : MonoBehaviour
{
    public float targetAngularVelocity = 10f; 
    public float torqueForce = 50f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() 
    {
        float velocityError = targetAngularVelocity - rb.angularVelocity.y;
        float finalTorque = velocityError * torqueForce;

        rb.AddTorque(Vector3.up * finalTorque);
    }
}