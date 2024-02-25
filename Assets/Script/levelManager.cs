using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class levelManage : MonoBehaviour
{
    private bool isPaused = false;
    public TextMeshProUGUI counterText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
            SceneManager.LoadScene(0);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPaused)
            {
                ResumeGame();
                counterText.text = "";
            }
            else
            {
                PauseGame();
                counterText.text = "Pause";
            }
        }
    }

    void ResetGame()
    { 
        saveColunter.RescuingCount = 0;
        saveColunter.savedCount = 0;
        SoliderManager.itemCount = 7;
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

}
