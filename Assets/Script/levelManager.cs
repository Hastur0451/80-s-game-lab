using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManage : MonoBehaviour
{
    void Update()
    {
        // ����Ƿ�����'R'��
        if (Input.GetKeyDown(KeyCode.R))
        {
            // ʹ��SceneManager���¼��ص�ǰ����ĳ������Ӷ�������Ϸ
            Debug.Log("��������");
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
