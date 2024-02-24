using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoliderManager : MonoBehaviour
{
    public static int itemCount = 7; // ���ٳ������ض�Prefab������
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
    // ���µ�Prefabʵ��������ʱ����
    public void ItemAdded()
    {
        itemCount++;
    }

    // ��Prefabʵ��������ʱ����
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
