using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public static GameTimer instance;

    public TextMeshProUGUI timerText;
    public GameObject finishPanel;
    public TextMeshProUGUI finalTimeText;
    public TextMeshProUGUI resetText;

    private float time;
    private bool isRunning = true;

    void Awake()
    {
        // Make timer persist between scenes
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (!isRunning) return;

        time += Time.deltaTime;
        UpdateTimerUI();
    }

    void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);

        if (timerText != null)
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StopTimer()
    {
        isRunning = false;

        if (finishPanel != null)
            finishPanel.SetActive(true);

        if (finalTimeText != null)
            finalTimeText.text = "Final Time: " + timerText.text;

        if (resetText != null)
            resetText.text = "Reset Count: " + PlayerCheckpoint.resetCount.ToString();
    }

    // Optional: manual reset
    public void ResetTimer()
    {
        time = 0f;
        isRunning = true;
    }
}