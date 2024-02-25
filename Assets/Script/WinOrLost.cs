using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLost : MonoBehaviour
{
    public Camera mainCamera;
    public Transform gameOverTarget;
    public Transform gameWinTarget;
    public AudioSource audioSource;
    public AudioClip winClip;
    public AudioClip lostClip;

    public void WinGame()
    {
        audioSource.PlayOneShot(winClip);
        mainCamera.transform.position = gameWinTarget.position;
        mainCamera.transform.rotation = gameWinTarget.rotation;
        Time.timeScale = 0f;
    }

    public void LostGame()
    {
        audioSource.PlayOneShot(lostClip);
        mainCamera.transform.position = gameOverTarget.position;
        mainCamera.transform.rotation = gameOverTarget.rotation;
        Time.timeScale = 0f;
    }

}
