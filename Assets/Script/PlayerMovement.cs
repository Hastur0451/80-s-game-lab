using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // 可以在Inspector中修改的移动速度

    private Rigidbody2D rb; // 游戏对象的Rigidbody2D组件引用
    private Vector2 movement; // 存储移动方向的向量

    // 在Start方法中获取Rigidbody2D组件
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // 在Update方法中处理输入
    void Update()
    {
        // 获取垂直和水平输入（W,S键和A,D键）
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize(); // 正规化移动向量，确保对角移动时速度不会增加
    }

    // 在FixedUpdate中处理物理移动
    void FixedUpdate()
    {
        // 使用Rigidbody2D组件来移动游戏对象
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
