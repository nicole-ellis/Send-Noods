using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenButtonAppear : MonoBehaviour
{

    public DialogueController Kit;
    public GameObject targetObject;
    private void Start() // if the conversation has not ended hide the Kitchen button
    {
        if (Kit.KitchenShow == 0)
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
    void Update()
    {
        if ((Kit.KitchenShow) == 1) // if the conversation has ended show the Kitchen button
        {
            targetObject.GetComponent<Image>().enabled = true;
        }
        else if ((Kit.KitchenShow) == 2) // if the conversation has ended show the Kitchen button
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
}
