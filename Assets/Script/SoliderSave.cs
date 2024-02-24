using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderSave : MonoBehaviour
{

    // 假设这个静态变量存储在某个地方，比如Player类中
    // 这里只是为了示例，你需要根据你的游戏架构来调整
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 检查是否与标记为“Player”的对象发生碰撞，并且Player的碰撞计数少于3次
        if (collision.gameObject.CompareTag("Player") && saveColunter.RescuingCount < 3)
        {
            Destroy(gameObject); // 销毁当前物体
            SoliderManager.ItemRemoved();
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            // 玩家已经碰撞到3个物体，不再销毁物体
            Debug.Log("Already collided with 3 objects, cannot destroy anymore.");
        }
    }
}
