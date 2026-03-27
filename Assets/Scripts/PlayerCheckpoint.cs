using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public Transform currentCheckpoint;
    public float deathY = -10f;

    void Start()
    {
        // Default = first spawn
        currentCheckpoint = GameManager.instance.spawnPoint;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawn();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawn();
        }

        if (transform.position.y < deathY)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        GameManager.instance.SpawnPlayer(currentCheckpoint);
    }
}