using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public Transform currentCheckpoint;

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
    }

    public void Respawn()
    {
        GameManager.instance.SpawnPlayer(currentCheckpoint);
    }
}