using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverScene : MonoBehaviour
{
    public Transform GameoOverTarget; 
    public Camera mainCamera; 

    private void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mainCamera.transform.position = GameoOverTarget.position;
            mainCamera.transform.rotation = GameoOverTarget.rotation;
        }
    }
}
