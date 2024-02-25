using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class time : MonoBehaviour
{
    public delegate void TimeAdjustmentHandler(int secondsToAdd);
    public static event TimeAdjustmentHandler OnTimeAdjustment;
    public float timeRemaining = 20;
    public TextMeshProUGUI counterText;
    public WinOrLost winOrLost;
    private bool end = false;

    void Start()
    {
        OnTimeAdjustment += AdjustTime;
    }

    void Update()
    {
        if (!end)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                counterText.text = "Time left: " + Mathf.CeilToInt(timeRemaining);
            }
            else
            {
                TimeExpired();
                end = true;
            }
        }
    }

    void TimeExpired()
    {
        winOrLost.LostGame();
    }

    public void AdjustTime(int secondsToAdd)
    {
        timeRemaining += secondsToAdd;
    }

    public static void TriggerTimeAdjustment(int secondsToAdd)
    {
        OnTimeAdjustment?.Invoke(secondsToAdd);
    }

    void OnDestroy()
    {
        OnTimeAdjustment -= AdjustTime;
    }
}
