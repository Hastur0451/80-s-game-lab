using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText; // ָ�����TextMeshProUGUI���������
    private int counter = 0; // ����������

    // �������Ӽ�����������UI�ı��ķ���
    public void IncrementCounter()
    {
        counter++; // ���Ӽ�����
        counterText.text = "Count: " + counter; // ����TextMeshPro�ı�
    }
}
