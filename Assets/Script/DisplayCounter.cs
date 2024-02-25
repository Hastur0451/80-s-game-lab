using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    private int counter = 0;

    public void IncrementCounter()
    {
        counter++;
        counterText.text = "Count: " + counter;
    }
}
