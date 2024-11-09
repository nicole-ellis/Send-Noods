using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kitchen2 : MonoBehaviour
{


    public DialogueController Kit;
    public GameObject targetObject;


    public NFwho NFwho;
    public NFWhere NFWhere;
    public NFAlive NFAlive;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Kit.KitchenShow) >= 3 && NFwho.NFQuestion1 == 0 && NFAlive.NFQuestion3 == 0 && NFWhere.NFQuestion2 == 0) // if the conversation has ended show the Kitchen button
        {
            targetObject.GetComponent<Image>().enabled = true;
        }
        else if ((Kit.KitchenShow) == 0 || NFwho.NFQuestion1 == 1 || NFWhere.NFQuestion2 == 1 || NFAlive.NFQuestion3 == 1) // if the conversation has ended show the Kitchen button
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
}
