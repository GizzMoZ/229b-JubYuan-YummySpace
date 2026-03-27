using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("LEVEL COMPLETE!");
            // You can load next scene here later
        }
    }
}