using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class saveColunter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public static int collisionCount = 0;
    public string targetTag = "Collectible";


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag(targetTag))
        {
            if (collisionCount >= 3)
            {
                Debug.Log("Cannot destroy anymore! Total destroyed: " + collisionCount);
            }

            else if (collisionCount < 3)
            {
                collisionCount++;
                Destroy(other.gameObject);
                Debug.Log("Destroyed: " + other.gameObject.name + ". Total destroyed: " + collisionCount);
            }
        }
    }

    public void Update()
    {
        counterText.text = "Rescuing " + collisionCount + "/3";
    }

}
