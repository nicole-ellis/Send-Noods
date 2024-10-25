using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kitchenButtonShow : MonoBehaviour
{
    public GameObject objectToActivate; // Reference to the GameObject you want to activate

    void Start()
    {
        // Deactivate the GameObject
        objectToActivate.SetActive(false);

        // You can call ActivateObject after a delay, for example
        Invoke("ActivateObject", 2f); // Activates the GameObject after 2 seconds
    }

    void ActivateObject()
    {
        // Activate the GameObject
        objectToActivate.SetActive(true);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Example: pressing space activates the GameObject
        {
            objectToActivate.SetActive(true);
        }
    }
}
