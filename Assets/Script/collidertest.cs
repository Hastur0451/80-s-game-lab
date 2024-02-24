using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidertest : MonoBehaviour
{
    // 当发生碰撞时调用
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected with " + collision.gameObject.name);
    }

    // 当触发器被触发时调用
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Entered with " + other.gameObject.name);
    }
}
