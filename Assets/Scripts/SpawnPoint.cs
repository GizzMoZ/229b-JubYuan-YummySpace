using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject player;

    void Start()
    {
        Instantiate(player, spawnPoint.position, spawnPoint.rotation);
    }
}
