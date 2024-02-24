using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderSave : MonoBehaviour
{

    // ���������̬�����洢��ĳ���ط�������Player����
    // ����ֻ��Ϊ��ʾ��������Ҫ���������Ϸ�ܹ�������
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ����Ƿ�����Ϊ��Player���Ķ�������ײ������Player����ײ��������3��
        if (collision.gameObject.CompareTag("Player") && saveColunter.RescuingCount < 3)
        {
            Destroy(gameObject); // ���ٵ�ǰ����
            SoliderManager.ItemRemoved();
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            // ����Ѿ���ײ��3�����壬������������
            Debug.Log("Already collided with 3 objects, cannot destroy anymore.");
        }
    }
}
