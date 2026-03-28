using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    public static int resetCount = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            resetCount++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}