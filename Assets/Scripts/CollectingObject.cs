using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public AudioClip collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);

            Destroy(other.gameObject);
        }
    }
}