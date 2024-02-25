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
    public Transform GameoOverTarget;
    public TextMeshProUGUI counterText;
    public Camera mainCamera;

    void Start()
    {
        OnTimeAdjustment += AdjustTime;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            counterText.text ="Time left: "+ (Mathf.CeilToInt(timeRemaining));
        }
        else
        {
            TimeExpired();
        }
    }

    void TimeExpired()
    {
        mainCamera.transform.position = GameoOverTarget.position;
        mainCamera.transform.rotation = GameoOverTarget.rotation;
        Time.timeScale = 0f;
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
