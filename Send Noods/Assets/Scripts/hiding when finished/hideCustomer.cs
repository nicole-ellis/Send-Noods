using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideCustomer : MonoBehaviour
{

    public DialogueController Kit;
    public GameObject targetObject;
    private void Start() // if the conversation has not ended show the customer
    {
        if (Kit.KitchenShow == 0)
        {
            targetObject.GetComponent<Image>().enabled = true;
        }
    }
    void Update()
    {
        if ((Kit.KitchenShow) == 1) // if the conversation has ended hide the customer
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
}
