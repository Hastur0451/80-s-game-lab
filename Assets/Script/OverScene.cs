using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverScene : MonoBehaviour
{
    public Transform GameoOverTarget; // ������ƶ�����Ŀ��λ�ú���ת
    public Camera mainCamera; // �������

    private void Start()
    {
        if (mainCamera == null)
        {
            // ���δָ�����Զ��ҵ��������
            mainCamera = Camera.main;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ȷ��ֻ����Ҵ���������ƶ�
        {
            // �ƶ��������Ԥ���Ŀ��λ�ú���ת
            mainCamera.transform.position = GameoOverTarget.position;
            mainCamera.transform.rotation = GameoOverTarget.rotation;
        }
    }
}
