using UnityEngine;
using TMPro;
using UnityEditor;

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject finishPanel;
    public TextMeshProUGUI finalTimeText;
    public TextMeshProUGUI resetText;

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

    if (finishPanel != null) finishPanel.SetActive(true);

    if (finalTimeText != null) finalTimeText.text = "Final Time: " + timerText.text;

    if (resetText != null) 
    {
        resetText.text = "Reset Count: " + PlayerCheckpoint.resetCount.ToString();
        Debug.Log("UI Updated with: " + PlayerCheckpoint.resetCount); // เช็คใน Console อีกที
    }
}
}