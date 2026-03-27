using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject finishPanel;
    public TextMeshProUGUI finalTimeText;

    private float time;
    private bool isRunning = true;

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

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StopTimer()
    {
        isRunning = false;

        // 🖥 Show finish UI
        finishPanel.SetActive(true);

        // 🥇 Show final time
        finalTimeText.text = "Final Time: " + timerText.text;
    }
}