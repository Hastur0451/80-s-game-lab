using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class time : MonoBehaviour
{
    public float timeRemaining = 20;
    public Transform GameoOverTarget;
    public TextMeshProUGUI counterText;
    public Camera mainCamera;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            counterText.text ="Time left: "+ (Mathf.CeilToInt(timeRemaining));
            AdjustTime();
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

    public void AdjustTime()
    {
        timeRemaining += saveColunter.timeAdd * 3;
    }
}
