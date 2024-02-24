using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManage : MonoBehaviour
{
    void Update()
    {
        // 检测是否按下了'R'键
        if (Input.GetKeyDown(KeyCode.R))
        {
            // 使用SceneManager重新加载当前激活的场景，从而重启游戏
            Debug.Log("重新来过");
            ResetGame();
            SceneManager.LoadScene(0);
        }
    }

    void ResetGame()
    { 
        saveColunter.RescuingCount = 0;
        saveColunter.savedCount = 0;
        SoliderManager.itemCount = 7;
    } 

}
