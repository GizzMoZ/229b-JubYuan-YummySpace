using UnityEngine;

public class CheckpointSound : MonoBehaviour
{
    private AudioSource checkpointAudio;
    bool activated = false;
    void Start()
    {
        checkpointAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
            if (other.CompareTag("Player") && !activated)
            {
                activated = true;
                checkpointAudio.Play();
            }

    }
}

