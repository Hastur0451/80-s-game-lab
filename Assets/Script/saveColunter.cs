using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class saveColunter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public static int RescuingCount = 0;
    public static int savedCount = 0;
    public int timeAdd = 0;
    public string targetTag1 = "Solider";
    public string targetTag2 = "Camp";


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag(targetTag1))
        {
            if (RescuingCount >= 3)
            {
                Debug.Log("Cannot destroy anymore! Total destroyed: " + RescuingCount);
            }

            else if (RescuingCount < 3)
            {
                RescuingCount++;
                Destroy(other.gameObject);
                Debug.Log("Destroyed: " + other.gameObject.name + ". Total destroyed: " + RescuingCount);
            }
        }

        if (other.CompareTag(targetTag2))
        {
            savedCount = savedCount + RescuingCount;
            RescuingCount = 0;
        }
      }


    public void Update()
    {
        counterText.text = "Rescuing " + RescuingCount + "/3    Saved "+ savedCount;
    }

}
