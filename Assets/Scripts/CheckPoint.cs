using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCheckpoint pc = other.GetComponent<PlayerCheckpoint>();
            pc.currentCheckpoint = transform;
        }
    }
}