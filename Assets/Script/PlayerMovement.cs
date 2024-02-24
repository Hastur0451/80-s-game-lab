using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // ������Inspector���޸ĵ��ƶ��ٶ�

    private Rigidbody2D rb; // ��Ϸ�����Rigidbody2D�������
    private Vector2 movement; // �洢�ƶ����������

    // ��Start�����л�ȡRigidbody2D���
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // ��Update�����д�������
    void Update()
    {
        // ��ȡ��ֱ��ˮƽ���루W,S����A,D����
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize(); // ���滯�ƶ�������ȷ���Խ��ƶ�ʱ�ٶȲ�������
    }

    // ��FixedUpdate�д��������ƶ�
    void FixedUpdate()
    {
        // ʹ��Rigidbody2D������ƶ���Ϸ����
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
