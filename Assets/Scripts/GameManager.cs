using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform spawnPoint;
    public GameObject playerPrefab;

    private GameObject currentPlayer;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SpawnPlayer(spawnPoint);
    }

    public void SpawnPlayer(Transform spawnTransform)
    {
        if (currentPlayer != null)
        {
            Destroy(currentPlayer);
        }

        currentPlayer = Instantiate(playerPrefab, spawnTransform.position, spawnTransform.rotation);
    }
}