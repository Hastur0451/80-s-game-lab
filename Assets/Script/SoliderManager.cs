using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoliderManager : MonoBehaviour
{
    public static int itemCount = 7; // 跟踪场景中特定Prefab的数量
    public Transform WinTarget;
    public Camera mainCamera;
    public TextMeshProUGUI counterText;

    private void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }
    // 当新的Prefab实例被创建时调用
    public void ItemAdded()
    {
        itemCount++;
    }

    // 当Prefab实例被销毁时调用
    public static void ItemRemoved()
    {
        itemCount--;
    }

    private void WinScreen()
    {
        if (itemCount == 0 && saveColunter.RescuingCount == 0)
        {
            mainCamera.transform.position = WinTarget.position;
            mainCamera.transform.rotation = WinTarget.rotation;
        }
    }

    public void Update()
    {
        counterText.text = "itemCount "+ itemCount;
        WinScreen();
    }
}
