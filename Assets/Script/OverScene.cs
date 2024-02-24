using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverScene : MonoBehaviour
{
    public Transform GameoOverTarget; // 摄像机移动到的目标位置和旋转
    public Camera mainCamera; // 主摄像机

    private void Start()
    {
        if (mainCamera == null)
        {
            // 如果未指定，自动找到主摄像机
            mainCamera = Camera.main;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 确保只有玩家触发摄像机移动
        {
            // 移动摄像机到预设的目标位置和旋转
            mainCamera.transform.position = GameoOverTarget.position;
            mainCamera.transform.rotation = GameoOverTarget.rotation;
        }
    }
}
