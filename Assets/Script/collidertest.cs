using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidertest : MonoBehaviour
{
    // ��������ײʱ����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected with " + collision.gameObject.name);
    }

    // ��������������ʱ����
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Entered with " + other.gameObject.name);
    }
}
