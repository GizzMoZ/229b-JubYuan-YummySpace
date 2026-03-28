using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCredit : MonoBehaviour
{
    public void OpenCredit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void BackToMenu()
{
    SceneManager.LoadScene("MainMenu");
}
}
