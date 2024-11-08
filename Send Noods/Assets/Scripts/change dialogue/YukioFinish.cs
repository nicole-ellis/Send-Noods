using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YukioFinish : MonoBehaviour
{

    public DialogueController Kit;
    public GameObject targetObject;

    // Update is called once per frame
    void Update()
    {
        if (Kit.KitchenShow == 2)
        {
            targetObject.SetActive(false);
        }
    }
}
