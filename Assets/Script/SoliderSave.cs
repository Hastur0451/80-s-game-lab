using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderSave : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with Player, destroying object.");
        Destroy(gameObject);
    }
}
