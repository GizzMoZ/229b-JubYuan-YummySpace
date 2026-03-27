using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCheckpoint : MonoBehaviour
{
    public Transform currentCheckpoint;
    public float deathY = -10f;

    private bool isDead = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentCheckpoint = GameManager.instance.spawnPoint;
    }

    void Update()
    {
        // 💀 Detect fall
        if (!isDead && transform.position.y < deathY)
        {
            Die();
        }

        // 🔁 R works ALWAYS
        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawn();
        }

        // ❌ Q only when dead
        if (isDead && Input.GetKeyDown(KeyCode.Q))
        {
            QuitGame();
        }
    }

    void Die()
    {
        isDead = true;

        rb.linearVelocity = Vector3.zero;
        rb.isKinematic = true;

        Debug.Log("You Died! Press R to Respawn or Q to Quit");
    }

    void Respawn()
    {
        GameManager.instance.SpawnPlayer(currentCheckpoint);

        isDead = false;
        rb.isKinematic = false;
    }

    void QuitGame()
    {
        Debug.Log("Quit Game");

        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}