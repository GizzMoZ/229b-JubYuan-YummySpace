using UnityEngine;

public class ItemRotator : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 180, 0); 

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
