using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenButtonAppear : MonoBehaviour
{

    public DialogueController Kit;
    public GameObject targetObject;
    private void Start()
    {
        if (Kit.KitchenShow == 0)
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
    void Update()
    {
        if ((Kit.KitchenShow) == 1)
        {
            targetObject.GetComponent<Image>().enabled = true;
            Debug.Log("Yes, it works");
        }
        else
        {
            
        }
    }
}
