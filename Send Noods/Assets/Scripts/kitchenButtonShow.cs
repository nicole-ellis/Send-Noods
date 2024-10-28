using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TargetScript : MonoBehaviour
{
    public GameObject objectToHide;

    void Start()
    {
        // Disable the Renderer component to make the GameObject invisible
        Renderer renderer = objectToHide.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
    }
}
