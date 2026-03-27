using UnityEngine;

public class SimplePatrol : MonoBehaviour
{
    public float speed = 2f;      
    public float range = 3f;      
    private Vector3 startPos;     

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        
        float xOffset = Mathf.PingPong(Time.time * speed, range * 2) - range;
        
        transform.position = new Vector3(startPos.x + xOffset, startPos.y, startPos.z);
    }
}