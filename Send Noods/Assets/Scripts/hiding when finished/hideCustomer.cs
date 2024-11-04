using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class hideCustomer : MonoBehaviour
{

    public DialogueController Kit;
    public GameObject targetObject;

    public Vector3 currentPosition; // Variable to store the current position
    public Vector3 newPosition;

    public bool allowMoveChef = false;
    private void Start() // if the conversation has not ended show the customer
    {
        if (Kit.KitchenShow == 0)
        {
            targetObject.GetComponent<SpriteRenderer>().enabled = true;
            //targetObject.SetActive(true);
            currentPosition = transform.position; // Get and save the current position
            transform.position = currentPosition; // Set the position to current
        }
    }
    void Update()
    {
        if ((Kit.KitchenShow) == 1 && allowMoveChef == false || Kit.KitchenShow == 2) // if the conversation has ended hide the customer
        {
            newPosition = currentPosition;
            newPosition.x += 10;
            transform.position = newPosition;
            //targetObject.SetActive(false);

        }
        else if (Kit.KitchenShow == 0)
        {
            targetObject.GetComponent<SpriteRenderer>().enabled = true;
            //targetObject.SetActive(true);
            currentPosition = transform.position; // Get and save the current position
            transform.position = currentPosition; // Set the position to current
        }
    }
}
