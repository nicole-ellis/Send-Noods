using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButtonHide : MonoBehaviour
{
    public GameObject objectToActivate; // Reference to the GameObject you want to activate

    void Start()
    {
        // Deactivate the GameObject
        objectToActivate.SetActive(true);

        // You can call ActivateObject after a delay, for example
        Invoke("ActivateObject", 0f); // Activates the GameObject after 2 seconds
    }

    void ActivateObject()
    {
        // Activate the GameObject
        objectToActivate.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Example: pressing space activates the GameObject
        {
            objectToActivate.SetActive(false);
        }
    }
}
