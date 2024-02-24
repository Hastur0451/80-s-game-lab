using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText; // 指向你的TextMeshProUGUI组件的引用
    private int counter = 0; // 计数器变量

    // 用于增加计数器并更新UI文本的方法
    public void IncrementCounter()
    {
        counter++; // 增加计数器
        counterText.text = "Count: " + counter; // 更新TextMeshPro文本
    }
}
