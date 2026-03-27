using UnityEngine;

public class LevitateBobbing : MonoBehaviour
{

    public float floatAmplitude = 0.5f; 

    public float floatSpeed = 1f;

    private Vector3 initialPosition;

    void Start()
    {
        // Store the object's initial position
        initialPosition = transform.position;
    }

    void Update()
    {
        float newY = initialPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}