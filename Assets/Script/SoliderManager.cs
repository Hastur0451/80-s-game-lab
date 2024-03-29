using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoliderManager : MonoBehaviour
{
    public static int itemCount = 7; 
    public Transform WinTarget;
    public Camera mainCamera;
    public TextMeshProUGUI counterText;
    public static AudioSource audioSource;
    public static AudioClip destroySound;
    public static float volume = 1.0f;
    public AudioClip destroySoundInspector;
    public WinOrLost winOrLost;
    private bool end = false;

    private void Awake()
    {
        if (audioSource == null)
        {
            destroySound = destroySoundInspector;
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }


    public static void ItemRemoved()
    {
        itemCount--;
        audioSource.PlayOneShot(destroySound, volume);
    }

    private void WinScreen()
    {
        if (itemCount == 0 && saveColunter.RescuingCount == 0 && !end)
        {
            end = true;
            winOrLost.WinGame();
        }
    }

    public void Update()
    {
        counterText.text = itemCount + "  Solider left ";
        WinScreen();
    }
}
