using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderSave : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && saveColunter.RescuingCount < 3)
        {
            Destroy(gameObject);
            SoliderManager.ItemRemoved();
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Already collided with 3 objects, cannot destroy anymore.");
        }
    }
}
