using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelPortal : MonoBehaviour
{
    public string nextSceneName = "Leve_3"; 
    public float delay = 1f;                

    private bool isLoading = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isLoading && other.CompareTag("Player"))
        {
            isLoading = true;
            StartCoroutine(LoadNextLevel());
        }
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nextSceneName);
    }
}